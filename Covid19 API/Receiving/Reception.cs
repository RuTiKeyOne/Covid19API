using Covid19_API.Countries;
using Covid19_API.DayOne;
using Covid19_API.DayOneAllStatus;
using Covid19_API.DayOneLive;
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
            Response = Client.GetResponce($"https://api.covid19api.com/dayone/country/{country}/status/confirmed");
            CountryDayOneAllStatusData = JsonConvert.DeserializeObject<List<CountryDayOneAllStatusData>>(Response.Content);
            return CountryDayOneAllStatusData;
        }

        /*Returns all cases by case type for a country from the first recorded case with the latest record being the live count. 
        Country must be the Slug from /countries or /summary. Cases must be one of: confirmed, recovered, deaths
        */
        public List<CountryDayOneLiveData> ReceivingCountryDayOneLiveData(string country)
        {
            Response = Client.GetResponce($"https://api.covid19api.com/dayone/country/{country}/status/confirmed");
            CountryDayOneLiveData = JsonConvert.DeserializeObject<List<CountryDayOneLiveData>>(Response.Content);
            return CountryDayOneLiveData;
        }
    }
}
