using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FinTech.MultiTenancy.HostDashboard.Dto;

namespace FinTech.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}