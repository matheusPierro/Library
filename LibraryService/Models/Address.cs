using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryService.Models
{
    public class Address
    {

        public int id { get; set; }
        public string neighborhood { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string zipCode { get; set; }
        public string complement { get; set; }

        public Address() { }

        public Address(int id, string neighborhood, string city, string state, string country, string zipCode, string complement)
        {
            this.id = id;
            this.neighborhood = neighborhood;
            this.city = city;
            this.state = state;
            this.country = country;
            this.zipCode = zipCode;
            this.complement = complement;
        }
    }
}
