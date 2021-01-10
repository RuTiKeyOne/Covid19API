using RestSharp;
using System;

namespace Covid19_API.Receiving
{
    public class ReceptionClient
    {
        public IRestResponse GetResponce(string url)
        {
            RestClient Client = new RestClient(url);
            RestRequest Request = new RestRequest(Method.GET);
            return Client.Execute(Request);
        }
    }
}
