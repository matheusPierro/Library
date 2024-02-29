using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryService.Models
{
    public class Rental
    {
        private int id { get; set; }
        private DateTime initialRentalDate { get; set; }
        private DateTime limitDate { get; set; }
        private DateTime returnDate { get; set; }
        private Book book { get; set; }
        private decimal rentalPrice { get; set; }
        private int fee { get; set; }

        public Rental()
        { }

        public Rental(int id, DateTime initialRentalDate, DateTime limitDate, DateTime returnDate, Book book, decimal rentalPrice, int fee)
        {
            id = id;
            initialRentalDate = initialRentalDate;
            limitDate = limitDate;
            returnDate = returnDate;
            book = book;
            rentalPrice = rentalPrice;
            fee = fee;
        }

        internal virtual string bookReservation()
        {
            return "This method will be overrided";
        }

        private DateTime defineLimitDate(DateTime initialRentalDate)
        {

            return new DateTime(limitDate.Year, limitDate.Month, limitDate.Day, limitDate.Hour, limitDate.Minute, limitDate.Second);

        }

        protected decimal calcFee(decimal rentalPrice, int fee)
        {
            return fee;
        }

        public decimal applyFee()
        {
            return calcFee(0, fee);
        }

    }
}
