using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAdmision.Models
{
    public class Address : BaseModel
    {
        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string LandMark { get; set; }

        public string AreaName { get; set; }

        public string City { get; set; }

        public string District { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public string PINCode { get; set; }
    }
}
