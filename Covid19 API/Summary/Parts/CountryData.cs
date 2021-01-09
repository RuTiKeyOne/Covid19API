using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19_API.Summary.Parts
{
    public class CountryData
    {
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public string Slug { get; set; }
        public string NewConfirmed { get; set; }
        public string TotalConfirmed { get; set; }
        public string NewDeaths { get; set; }
        public string TotalDeaths { get; set; }
        public string NewRecovered { get; set; }
        public string TotalRecovered { get; set; }
        public string Date { get; set; }
    }
}
