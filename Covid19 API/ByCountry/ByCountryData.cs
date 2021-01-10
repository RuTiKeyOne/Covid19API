using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19_API.ByCountry
{
    public class ByCountryData
    {
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public string Lat { get; set; }
        public string Lon { get; set; }
        public string Cases { get; set; }
        public string Status { get; set; }
        public string Date { get; set; }
    }
}
