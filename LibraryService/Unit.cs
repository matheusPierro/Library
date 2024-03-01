namespace LibraryService.Models
{
    public class Unit
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<Book> books { get; set; }
        public Address address { get; set; }
        public Rental rental { get; set; }

        public Unit() { }

        public Unit(int id, string name, List<Book> books, Address address, Rental rental)
        {
            this.id = id;
            this.name = name;
            this.books = books;
            this.address = address;
            this.rental = rental;
        }
    }

    public class Paulista : Rental
    {

        internal override string bookReservation()
        {
            // there will be an extra 15 days in the rental limit
            limitDate = limitDate.AddDays(15); // 45 days
            return $"Rental made for Paulista with deadline for return in {limitDate.ToShortDateString()}.";
        }

    }
    public class VilaOlimpia : Rental
    {

        internal override string bookReservation()
        {
            if (book.category.name == "Técnico")
            {
                rentalAmount *= 0.9m; // 10% discount
            }
            return $"Rental made for Vila Olimpia with price {rentalAmount}.";
        }

    }
    public class Aclimacao : Rental
    {

        internal override string bookReservation()
        {
            rentalAmount *= 0.85m; // 15% student discount
            return $"Rental made for Aclimação with special student price: {rentalAmount}.";
        }

    }

}