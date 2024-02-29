using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryService.Models
{
    public class Autor : Person
    {
        private int id { get; set; }
        private List<Book> books { get; set; }
        private string biography { get; set; }
        private List<String> publishers { get; set; }

        public Autor() { }

        public Autor(int id, List<Book> books, string biography, List<string> publishers)
        {
            this.id = id;
            this.books = books;
            this.biography = biography;
            this.publishers = publishers;
        }
    }
}
