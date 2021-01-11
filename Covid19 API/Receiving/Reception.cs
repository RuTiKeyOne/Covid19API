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
using Covid19_API.Summary;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;

namespace Covid19_API.Receiving
{
    public class Reception
    {
        private IRestResponse Response { get; set; }
        private ReceptionClient Client { get; set; }
        private List<CountriesData> Countries { get; set; }
        private List<CountryDayOneData> CountryDayOneData { get; set; }
        private List<CountryDayOneAllStatusData> CountryDayOneAllStatusData { get; set; }
        private List<CountryDayOneLiveData> CountryDayOneLiveData { get; set; }
        private List<CountryDayOneTotalData> CountryDayOneTotal { get; set; }
        private List<CountryDayOneTotalAllStatusData> CountryDayOneTotalAllStatus { get; set; }
        private List<ByCountryData> ByCountryData { get; set; } 
        private List<ByCountryAllStatusData> ByCountryAllStatusData { get; set; }
        private List<ByCountryLiveData> ByCountryLiveData { get; set; }
        private List<ByCountryTotalData> ByCountryTotalData { get; set; }
        private List<ByCountryTotalAllStatusData> ByCountryTotalAllStatusData { get; set; }
        public Reception()
        {
            Client = new();
        }
        //Get a summary of new and total cases per country updated daily sync
        public SummaryData ReceivingSummaryData()
        {
            Response = Client.GetResponce("https://api.covid19api.com/summary");
            SummaryData Summary = JsonConvert.DeserializeObject<SummaryData>(Response.Content);
            return Summary;
        }

        //Returns all the available countries and provinces, as well as the country slug for per country requests.
        public List<CountriesData> ReceivingCountriesData()
        {
            Response = Client.GetResponce("https://api.covid19api.com/countries");
            Countries = JsonConvert.DeserializeObject<List<CountriesData>>(Response.Content);
            return Countries;
        }
        /*Returns all cases by case type for a country from the first recorded case. 
        Country must be the Slug from /countries or /summary. Cases must be one of: confirmed, recovered, deaths
        */
        public List<CountryDayOneData> ReceivingCountryDayOneData(string country)
        {
            Response = Client.GetResponce($"https://api.covid19api.com/dayone/country/{country}/status/confirmed");
            CountryDayOneData = JsonConvert.DeserializeObject<List<CountryDayOneData>>(Response.Content);
            return CountryDayOneData;
        }
        /*Returns all cases by case type for a country from the first recorded case. 
        Country must be the Slug from /countries or /summary. Cases must be one of: confirmed, recovered, deaths
        */
        public List<CountryDayOneAllStatusData> ReceivingCountryDayOneAllStatusData(string country)
        {
            Response = Client.GetResponce($"https://api.covid19api.com/dayone/country/{country}");
            CountryDayOneAllStatusData = JsonConvert.DeserializeObject<List<CountryDayOneAllStatusData>>(Response.Content);
            return CountryDayOneAllStatusData;
        }

        /*Returns all cases by case type for a country from the first recorded case with the latest record being the live count. 
        Country must be the Slug from /countries or /summary. Cases must be one of: confirmed, recovered, deaths
        */
        public List<CountryDayOneLiveData> ReceivingCountryDayOneLiveData(string country)
        {
            Response = Client.GetResponce($"https://api.covid19api.com/dayone/country/{country}/status/confirmed/live");
            CountryDayOneLiveData = JsonConvert.DeserializeObject<List<CountryDayOneLiveData>>(Response.Content);
            return CountryDayOneLiveData;
        }

        /*
        Returns all cases by case type for a country from the first recorded case. Country must be the slug from /countries or /summary. 
        Cases must be one of: confirmed, recovered, deaths
        */
        public List<CountryDayOneTotalData> ReceivingCountryDayOneTotal(string country)
        {
            Response = Client.GetResponce($"https://api.covid19api.com/total/dayone/country/{country}/status/confirmed");
            CountryDayOneTotal = JsonConvert.DeserializeObject<List<CountryDayOneTotalData>>(Response.Content);
            return CountryDayOneTotal;
        }
        /*
        Returns all cases by case type for a country from the first recorded case. 
        Country must be the slug from /countries or /summary. Cases must be one of: confirmed, recovered, deaths
         */
        public List<CountryDayOneTotalAllStatusData> ReceivingCountryDayOneTotalAllStatus(string country)
        {
            Response = Client.GetResponce($"https://api.covid19api.com/total/dayone/country/{country}");
            CountryDayOneTotalAllStatus = JsonConvert.DeserializeObject<List<CountryDayOneTotalAllStatusData>>(Response.Content);
            return CountryDayOneTotalAllStatus;
        }

        /*
        Returns all cases by case type for a country. Country must be the slug from /countries or /summary. 
        Cases must be one of: confirmed, recovered, deaths 
         */
        public List<ByCountryData> ReceivingByCountryData(string country, string fromTime, string toTime)
        {
            Response = Client.GetResponce($"https://api.covid19api.com/country/{country}/status/confirmed?from={fromTime}T00:00:00Z&to={toTime}T00:00:00Z");
            ByCountryData = JsonConvert.DeserializeObject<List<ByCountryData>>(Response.Content);
            return ByCountryData;
        }

        public List<ByCountryAllStatusData> ReceivingByCountryAllStatusData(string country, string fromTime, string toTime)
        {
            Response = Client.GetResponce($"https://api.covid19api.com/country/{country}?from={fromTime}T00:00:00Z&to={toTime}T00:00:00Z");
            ByCountryAllStatusData = JsonConvert.DeserializeObject<List<ByCountryAllStatusData>>(Response.Content);
            return ByCountryAllStatusData;
        }

        public List<ByCountryLiveData> ReceivingByCountryLiveData(string country, string fromTime, string toTime)
        {
            Response = Client.GetResponce($"https://api.covid19api.com/country/{country}/status/confirmed/live?from={fromTime}T00:00:00Z&to={toTime}T00:00:00Z");
            ByCountryLiveData = JsonConvert.DeserializeObject<List<ByCountryLiveData>>(Response.Content);
            return ByCountryLiveData;
        }

        /*
        Returns all cases by case type for a country. Country must be the slug from /countries or /summary. 
        Cases must be one of: confirmed, recovered, deaths
        */
        public List<ByCountryTotalData> ReceivingByCountryTotalData(string country, string fromTime, string toTime)
        {
            Response = Client.GetResponce($"https://api.covid19api.com/total/country/{country}/status/confirmed?from={fromTime}T00:00:00Z&to={toTime}T00:00:00Z");
            ByCountryTotalData = JsonConvert.DeserializeObject<List<ByCountryTotalData>>(Response.Content);
            return ByCountryTotalData;
        }

        /*
        Returns all cases by case type for a country. Country must be the slug from /countries or /summary. 
        Cases must be one of: confirmed, recovered, deaths
        */
        public List<ByCountryTotalAllStatusData> ReceivingByCountryTotalAllStatusData(string country)
        {
            Response = Client.GetResponce($"https://api.covid19api.com/total/country/{country}");
            ByCountryTotalAllStatusData = JsonConvert.DeserializeObject<List<ByCountryTotalAllStatusData>>(Response.Content);
            return ByCountryTotalAllStatusData;
        }
    }
}
