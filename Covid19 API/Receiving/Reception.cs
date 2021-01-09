using Covid19_API.Summary;
using Newtonsoft.Json;
using RestSharp;

namespace Covid19_API.Receiving
{
    public class Reception
    {
        public SummaryData ReceivingSummaryData()
        {
            var Client = new RestClient("https://api.covid19api.com/summary");
            var Request = new RestRequest(Method.GET);
            IRestResponse Response = Client.Execute(Request);
            SummaryData Summary = JsonConvert.DeserializeObject<SummaryData>(Response.Content);
            return Summary;
        }

    }
}
