using Covid19_API.ByCountry;
using Covid19_API.ByCountryAllStatus;
using Covid19_API.ByCountryLive;
using Covid19_API.ByCountryTotal;
using Covid19_API.ByCountryTotalAllStatus;
using Covid19_API.Countries;
using Covid19_API.DayOne;
using Covid19_API.DayOneAllStatus;
using Covid19_API.DayOneLive;
using Covid19_API.DayOneTotal;
using Covid19_API.DayOneTotalAllStatus;
using Covid19_API.LiveByCountryAllStatus;
using Covid19_API.LiveByCountryAndStatus;
using Covid19_API.LiveByCountryAndStatusAfterDate;
using Covid19_API.Receiving;
using Covid19_API.Stats;
using Covid19_API.Summary;
using Covid19_API.Version;
using Covid19_API.WorldTotalWIP;
using Covid19_API.WorldWIP;
using System;
using System.Collections.Generic;

namespace Covid19_API
{
    class Program
    {
        static void Main(string[] args)
        {
            Reception Reception = new();
            List<WorldWIPData> CountryDayOneAllStatusData = Reception.ReceivingWorldWIPData("2020-05-01", "2020-06-01");
            foreach(var data in CountryDayOneAllStatusData)
            {
                Console.WriteLine($"New deaths is {data.NewDeaths}, total confirmed is {data.TotalConfirmed}");
            }
        }
    }
}

