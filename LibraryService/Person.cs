using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryService.Models
{
    public class Person
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime birth { get; set; }
        public string cpf { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public Address address { get; set; }

        public Person() { }

        public Person(int id, string name, DateTime birth, string cpf, string email, string phone, Address address)
        {
            this.id = id;
            this.name = name;
            this.birth = birth;
            this.cpf = cpf;
            this.email = email;
            this.phone = phone;
            this.address = address;
        }
    }
}
