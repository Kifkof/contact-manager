﻿using System.Collections.Generic;

namespace contact_manager.Models.Data
{
    public class DashboardData
    {

        public int ActiveCustomerCount { get; init; }

        public int PassiveCustomerCount { get; init; }

        public Dictionary<string, int> CityStatistics { get; init; }

        public Dictionary<string, int> CustomerTypeStatistics { get; set; }

        public DashboardData(int activeCustomerCount, int passiveCustomerCount,
            Dictionary<string, int> cityStatistics,
            Dictionary<string, int> customerTypeStatistics)
        {
            this.ActiveCustomerCount = activeCustomerCount;
            this.PassiveCustomerCount = passiveCustomerCount;
            this.CityStatistics = cityStatistics;
            this.CustomerTypeStatistics = customerTypeStatistics;
        }
    }
}
