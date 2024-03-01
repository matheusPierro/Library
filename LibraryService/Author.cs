using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryService.Models
{
    public class Author : Person
    {
        public int id { get; set; }
        public List<Book> books { get; set; }
        public string biography { get; set; }
        
        public Author() { }

        public Author(int id, string name,List<Book> books, string biography) 
        {
            this.id = id;
            this.name = name;
            this.books = books;
            this.biography = biography;
        }


    }
}
