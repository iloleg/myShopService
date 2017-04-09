
using System.Threading.Tasks;
using ShopService.Conventions.SVC.Queries;

namespace ShopService.Conventions.SVC.Extensions
{
    public class QueryBuilderExtensions
    {
        public static async Task<int> Count<TCriterion>(this IQueryBuilder queryBuilder, TCriterion criterion)
            where TCriterion : class, ICriterion
        {
            return await queryBuilder.For<int>().WithAsync(criterion);
        }
    }
}
