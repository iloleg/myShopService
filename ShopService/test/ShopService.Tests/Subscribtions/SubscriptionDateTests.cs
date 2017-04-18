﻿using System;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using ShopService.Conventions.SVC.Commands;
using ShopService.Conventions.SVC.Queries;
using ShopService.Conventions.Enums;
using ShopService.SVC.Commands;
using ShopService.SVC.Contexts;
using ShopService.SVC.Criterions.Subscriptions;
using ShopService.Entities;

namespace ShopService.Tests.Subscribtions
{
    [TestFixture]
    public class SubscriptionDateTests
    {
        private Mock<IQueryBuilder> _queryBuilderMock;
        private Mock<ICommandBuilder> _commandBuilderMock;

        [SetUp]
        public void SetUp()
        {
            _queryBuilderMock = new Mock<IQueryBuilder>();
            _commandBuilderMock = new Mock<ICommandBuilder>();
        }

        private void SetupMocks(long subscriptionId, SubscriptionDate lastSubscriptionDate)
        {
            _queryBuilderMock.Setup(x => x.For<long>()
                    .WithAsync(It.IsAny<SubscriptionIdCriterion>()))
                .ReturnsAsync(subscriptionId);

            _queryBuilderMock.Setup(x => x.For<SubscriptionDate>()
                    .WithAsync(It.IsAny<LastSubscriptionDateForSubscriptionRepositoryCriterion>()))
                .ReturnsAsync(lastSubscriptionDate);
        }

        [Test]
        public async Task ShouldAddSubcriptionDate_WhenSubscripingFirstTime()
        {
            var today = DateTime.Today;
            var subscriptionId = 1;
            SubscriptionDate subscriptionDate = null;
            SetupMocks(subscriptionId, subscriptionDate);
            var commandContext = new SuspendResumeSubscriptionContext(today);
            var command = new SuspendResumeSubscriptionCommand(_queryBuilderMock.Object, _commandBuilderMock.Object);

            await command.ExecuteAsync(commandContext);

            _commandBuilderMock.Verify(x => x.ExecuteAsync(It.Is<AddSubcriptionDateRepositoryContext>
                (y => y.SubscriptionDate.SubscriptionId == subscriptionId
                   && y.SubscriptionDate.Type == SubscriptionDateType.Start))
                , Times.Once);
        }

        [Test]
        public async Task ShouldRemoveLastSubcriptionDate_WhenSubscriptionHasBeenAlreadyStartedOrSuspendedToday()
        {
            var today = DateTime.Today;
            var subscriptionId = 1;
            var subscriptionDateId = 1;
            SubscriptionDate lastSubscriptionDate = new SubscriptionDate
            {
                Id = subscriptionDateId,
                SubscriptionId = subscriptionId,
                Date = DateTime.UtcNow
            };
            SetupMocks(subscriptionId, lastSubscriptionDate);
            var commandContext = new SuspendResumeSubscriptionContext(today);
            var command = new SuspendResumeSubscriptionCommand(_queryBuilderMock.Object, _commandBuilderMock.Object);

            await command.ExecuteAsync(commandContext);

            _commandBuilderMock.Verify(x => x.ExecuteAsync(It.Is<RemoveSubcriptionDateRepositoryContext>
                (y => y.SubscriptionDate.SubscriptionId == subscriptionId
                   && y.SubscriptionDate.Id == subscriptionDateId))
                , Times.Once);
        }

        [TestCase(SubscriptionDateType.Suspend)]
        [TestCase(SubscriptionDateType.Start)]
        public async Task ShouldAddResumedSubcriptionDate_WhenLastSubscriptionDateWasTypeOfStartedAndViceVersa
            (SubscriptionDateType type)
        {
            var today = DateTime.Today;
            var subscriptionId = 1;
            var subscriptionDateId = 1;
            SubscriptionDate lastSubscriptionDate = new SubscriptionDate
            {
                Id = subscriptionDateId,
                SubscriptionId = subscriptionId,
                Type = type
            };
            SetupMocks(subscriptionId, lastSubscriptionDate);
            var commandContext = new SuspendResumeSubscriptionContext(today);
            var command = new SuspendResumeSubscriptionCommand(_queryBuilderMock.Object, _commandBuilderMock.Object);

            await command.ExecuteAsync(commandContext);

            var newSubscriptionDateType = lastSubscriptionDate.Type == SubscriptionDateType.Start
                    ? SubscriptionDateType.Suspend
                    : SubscriptionDateType.Start;
            _commandBuilderMock.Verify(x => x.ExecuteAsync(It.Is<AddSubcriptionDateRepositoryContext>
                (y => y.SubscriptionDate.SubscriptionId == subscriptionId
                   && y.SubscriptionDate.Type == newSubscriptionDateType))
                , Times.Once);
        }
    }
}