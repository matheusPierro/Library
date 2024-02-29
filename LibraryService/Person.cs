using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryService.Models
{
    public class Person
    {
        private int id { get; set; }
        private string name { get; set; }
        private DateTime birth { get; set; }
        private string cpf { get; set; }
        private string email { get; set; }
        private string phone { get; set; }

        public Person() { }

        public Person(int id, string name, DateTime birth, string cpf, string email, string phone)
        {
            this.id = id;
            this.name = name;
            this.birth = birth;
            this.cpf = cpf;
            this.email = email;
            this.phone = phone;
        }
    }
}
