using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19_API.LiveByCountryAllStatus
{
    public class LiveByCountryAllStatusData
    {
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public string Lat { get; set; }
        public string Lon { get; set; }
        public string Confirmed { get; set; }
        public string Deaths { get; set; }
        public string Recovered { get; set; }
        public string Active { get; set; }
        public string Date { get; set; }
        public string LocationID { get; set; }
    }
}
