namespace LibraryService.Models
{
    public class Unit
    {
        public int id { get; set; }
        private string name { get; set; }
        private List<Book> books { get; set; }
        private Address address { get; set; }
        private Rental rental { get; set; }

        public Unit()
        { }

        public Unit(int id, string name, List<Book> books, Address address, Rental rental)
        {
            id = id;
            name = name;
            books = books;
            address = address;
            rental = rental;
        }
    }

    public class Paulista :  Rental
    {
        internal override string bookReservation()
        {
            return "";
        }
    }


    public class VilaOlimpia : Rental
    {
        internal override string bookReservation()
        {
            return "";
        }
    }


    public class Aclimacao : Rental
    {
        internal override string bookReservation()
        {
            return "";
        }
    }
}

