using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryService.Models
{
    public class Category
    {
        private int id { get; set; }
        internal string name { get; set; }
        private string description { get; set; }

        public Category() { }

        public Category(int id, string name, string description)
        {
            id = id;
            name = name;
            description = description;
        }
    }
}
