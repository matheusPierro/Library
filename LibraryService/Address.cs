using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryService.Models
{
    public class Address
    {
        private int Id { get; set; }
        private string neighborhood { get; set; }
        private string city { get; set; }
        private string state { get; set; }
        private string zipcode { get; set; }
        private string country { get; set; }
        private string complement { get; set; }

        public Address() { }

        public Address(string neighborhood, string city, string state, string zipcode, string country, string complement)
        {
            this.neighborhood = neighborhood;
            this.city = city;
            this.state = state;
            this.zipcode = zipcode;
            this.country = country;
            this.complement = complement;
        }
    }
}
