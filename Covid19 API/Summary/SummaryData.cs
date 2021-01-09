using Covid19_API.Summary.Parts;
using RestSharp;
using System;
using System.Collections.Generic;

namespace Covid19_API.Summary
{
    public class SummaryData
    {
        public GlobalData Global;
        public List<CountryData> Countries { get; set; } 
        public SummaryData()
        {
            Global = new();
            Countries = new();
        }
    }
}
