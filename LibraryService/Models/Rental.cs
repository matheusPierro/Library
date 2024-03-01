﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryService.Models
{
    public class Rental
    {
        public int id { get; set; }
        public DateTime initialRentalDate { get; set; }
        public DateTime limitDate { get; set; }
        public DateTime returnDate { get; set; }
        public Book book { get; set; }
        public decimal rentalAmount { get; set; }

        public Rental() { }

        public Rental(int id, DateTime initialRentalDate, DateTime returnDate, Book book, decimal rentalAmount)
        {
            this.id = id;
            this.initialRentalDate = initialRentalDate;
            this.limitDate = defineLimitDate(initialRentalDate);
            this.returnDate = returnDate;
            this.book = book;
            this.rentalAmount = rentalAmount;
        }

        public virtual string bookReservation()
        {
            return "This method will be overwritten.";
        }

        private DateTime defineLimitDate(DateTime initialRentalDate)
        {
            return initialRentalDate.AddDays(30);
        }

        protected decimal calcFee(decimal rentalAmount, int daysLate)
        {
            return daysLate > 0 ? rentalAmount * 0.05m * daysLate : 0; // 5% of the rental price per day of delay
        }

        internal decimal applyFee(decimal rentalAmount, int daysLate)
        {
            return calcFee(rentalAmount, daysLate);
        }
    }
}
