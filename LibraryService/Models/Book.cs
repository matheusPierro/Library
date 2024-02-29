using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace LibraryService.Models
{
    public class Book
    {
        private int id { get; set; }
        private string name { get; set; }
        private string description { get; set; }
        private Autor autor { get; set; }
        private Category categoria { get; set; }
        private bool available { get; set; }

        public Book(int id) {
            id = id;
        }

        public Book() : this(0) { }

        public Book(int id, string name, string description, Autor autor, Category categoria, bool available)
        {
            id = id;
            name = name;
            description = description;
            autor = autor;
            categoria = categoria;
            available = available;
        }


    }
}
