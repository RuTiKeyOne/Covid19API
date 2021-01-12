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
using Covid19_API.Stats;
using Covid19_API.Summary;
using Covid19_API.Version;
using Covid19_API.WorldTotalWIP;
using Covid19_API.WorldWIP;
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
        private List<LiveByCountryAndStatusData> LiveByCountryAndStatusData { get; set; }
        private List<LiveByCountryAllStatusData> LiveByCountryAllStatusData { get; set; }
        private List<LiveByCountryAndStatusAfterDateData> LiveByCountryAndStatusAfterDateData { get; set; }
        private List<WorldWIPData> WorldWIPData { get; set; }
        private WorldTotalWIPData WorldTotalWIPData { get; set; }
        private VersionData VersionData { get; set; }
        private StatsData StatsData { get; set; }
        public Reception()
        {
            Client = new();
        }

        //A summary of new and total cases per country updated daily.
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
        Country must be the Slug from /countries or /summary. 
        Cases must be one of: confirmed, recovered, deaths
        */
        public List<CountryDayOneData> ReceivingCountryDayOneData(string country)
        {
            Response = Client.GetResponce($"https://api.covid19api.com/dayone/country/{country}/status/confirmed");
            CountryDayOneData = JsonConvert.DeserializeObject<List<CountryDayOneData>>(Response.Content);
            return CountryDayOneData;
        }

        /*Returns all cases by case type for a country from the first recorded case. 
        Country must be the Slug from /countries or /summary. 
        Cases must be one of: confirmed, recovered, deaths
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
        Returns all cases by case type for a country from the first recorded case. 
        Country must be the slug from /countries or /summary. 
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
        Country must be the slug from /countries or /summary. 
        Cases must be one of: confirmed, recovered, deaths
        */
        public List<CountryDayOneTotalAllStatusData> ReceivingCountryDayOneTotalAllStatus(string country)
        {
            Response = Client.GetResponce($"https://api.covid19api.com/total/dayone/country/{country}");
            CountryDayOneTotalAllStatus = JsonConvert.DeserializeObject<List<CountryDayOneTotalAllStatusData>>(Response.Content);
            return CountryDayOneTotalAllStatus;
        }

        /*
        Returns all cases by case type for a country. 
        Country must be the slug from /countries or /summary. 
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
        Returns all cases by case type for a country. 
        Country must be the slug from /countries or /summary. 
        Cases must be one of: confirmed, recovered, deaths
        */
        public List<ByCountryTotalData> ReceivingByCountryTotalData(string country, string fromTime, string toTime)
        {
            Response = Client.GetResponce($"https://api.covid19api.com/total/country/{country}/status/confirmed?from={fromTime}T00:00:00Z&to={toTime}T00:00:00Z");
            ByCountryTotalData = JsonConvert.DeserializeObject<List<ByCountryTotalData>>(Response.Content);
            return ByCountryTotalData;
        }

        /*
        Returns all cases by case type for a country. 
        Country must be the slug from /countries or /summary. 
        Cases must be one of: confirmed, recovered, deaths
        */
        public List<ByCountryTotalAllStatusData> ReceivingByCountryTotalAllStatusData(string country)
        {
            Response = Client.GetResponce($"https://api.covid19api.com/total/country/{country}");
            ByCountryTotalAllStatusData = JsonConvert.DeserializeObject<List<ByCountryTotalAllStatusData>>(Response.Content);
            return ByCountryTotalAllStatusData;
        }

        /*
        Returns all live cases by case type for a country. These records are pulled every 10 minutes and are ungrouped. 
        Country must be the slug from /countries or /summary. 
        Cases must be one of: confirmed, recovered, deaths 
        */
        public List<LiveByCountryAndStatusData> ReceivingLiveByCountryAndStatusData(string country)
        {
            Response = Client.GetResponce($"https://api.covid19api.com/live/country/{country}/status/confirmed");
            LiveByCountryAndStatusData = JsonConvert.DeserializeObject<List<LiveByCountryAndStatusData>>(Response.Content);
            return LiveByCountryAndStatusData;
        }

        /*
        Returns all live cases by case type for a country. 
        These records are pulled every 10 minutes and are ungrouped. 
        Country must be the slug from /countries or /summary. Cases must be one of: confirmed, recovered, deaths
        */
        public List<LiveByCountryAllStatusData> ReceivingLiveByCountryAllStatusData(string country)
        {
            Response = Client.GetResponce($"https://api.covid19api.com/live/country/{country}");
            LiveByCountryAllStatusData = JsonConvert.DeserializeObject<List<LiveByCountryAllStatusData>>(Response.Content);
            return LiveByCountryAllStatusData;
        }

        /*
        Returns all live cases by case type for a country after a given date. 
        These records are pulled every 10 minutes and are ungrouped. 
        Country must be the slug from /countries or /summary. Cases must be one of: confirmed, recovered, deaths
        */
        public List<LiveByCountryAndStatusAfterDateData> ReceivingLiveByCountryAndStatusAfterDateData(string country, string afterTime)
        {
            Response = Client.GetResponce($"https://api.covid19api.com/live/country/{country}/status/confirmed/date/{afterTime}T00:00:00Z");
            LiveByCountryAndStatusAfterDateData = JsonConvert.DeserializeObject<List<LiveByCountryAndStatusAfterDateData>>(Response.Content);
            return LiveByCountryAndStatusAfterDateData;
        }

        /*
        Returns all live cases by case type for a country after a given date. 
        These records are pulled every 10 minutes and are ungrouped. 
        Country must be the slug from /countries or /summary. 
        Cases must be one of: confirmed, recovered, deaths
        */
        public List<WorldWIPData> ReceivingWorldWIPData(string fromTime, string toTime)
        {
            Response = Client.GetResponce($"https://api.covid19api.com/world?from={fromTime}T00:00:00Z&to={toTime}T00:00:00Z");
            WorldWIPData = JsonConvert.DeserializeObject<List<WorldWIPData>>(Response.Content);
            return WorldWIPData;
        }

        /*
        Returns all live cases by case type for a country after a given date. These records are pulled every 10 minutes and are ungrouped. 
        Country must be the slug from /countries or /summary. 
        Cases must be one of: confirmed, recovered, deaths
        */
        public WorldTotalWIPData ReceivingWorldTotalWIPData()
        {
            Response = Client.GetResponce($"https://api.covid19api.com/world/total");
            WorldTotalWIPData = JsonConvert.DeserializeObject<WorldTotalWIPData>(Response.Content);
            return WorldTotalWIPData;
        }

        //This route returns the usage of the API. This is not for any COVID related statistics.
        public StatsData ReceivingStatsData()
        {
            Response = Client.GetResponce($"https://api.covid19api.com/stats");
            StatsData = JsonConvert.DeserializeObject<StatsData>(Response.Content);
            return StatsData;
        }

        public string ReceivingVersionData()
        {
            VersionData = new();
            Response = Client.GetResponce($"https://api.covid19api.com/version");
            VersionData.Version = JsonConvert.DeserializeObject<string>(Response.Content);
            return VersionData.Version;
        }
    }
}
