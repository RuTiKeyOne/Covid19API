﻿using System;

namespace Covid19_API.ByCountryTotal
{
    public class ByCountryTotalData
    {
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string CityCode { get; set; }
        public string Lat { get; set; }
        public string Lon { get; set; }
        public string Cases { get; set; }
        public string Status { get; set; }
        public string Date { get; set; }
    }
}
