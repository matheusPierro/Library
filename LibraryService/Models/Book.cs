using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryService.Models
{
    public class Book
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public Author author { get; set; }
        public Category category { get; set; }
        public bool available { get; set; }

        public Book(int id)
        {
            this.id = id;
        }

        public Book() : this(0) { }

        public Book(int id, string name, string description, Author author, Category category, bool available)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.author = author;
            this.category = category;
            this.available = available;
        }
    }
}
