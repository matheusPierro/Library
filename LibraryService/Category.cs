using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryService.Models
{
    public class Category
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private string Description { get; set; }

        public Category() { }

        public Category(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
    }
}
