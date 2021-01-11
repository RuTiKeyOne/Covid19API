﻿using Covid19_API.ByCountry;
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
using Covid19_API.Receiving;
using Covid19_API.Summary;
using System;
using System.Collections.Generic;

namespace Covid19_API
{
    class Program
    {
        static void Main(string[] args)
        {
            Reception Reception = new();
            List<ByCountryTotalAllStatusData> ByCountryTotalData = Reception.ReceivingByCountryTotalAllStatusData("Russia");
            foreach(var data in ByCountryTotalData)
            {
                Console.WriteLine(data.Date);
            }
        }
    }
}

