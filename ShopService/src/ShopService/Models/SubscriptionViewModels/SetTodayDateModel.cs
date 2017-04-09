﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ShopService.Models.SubscriptionViewModels
{
    public class SetTodayDateModel
    {
        public SetTodayDateModel() { }

        public SetTodayDateModel(DateTime today)
        {
            Today = today;
        }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Today { get; set; }
    }
}
