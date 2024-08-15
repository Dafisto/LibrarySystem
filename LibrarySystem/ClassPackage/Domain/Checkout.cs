using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.ClassPackage.Domain
{
    internal class Checkout
    {
        private int rentalCode;
        private int customerID;
        private int isbn;

        public int RentalCode
        {
            get { return RentalCode; }
            set { RentalCode = value; }
        }
        public int CustomerID 
        {
            get { return customerID; }
            set { customerID = value; }
        }
        public int Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }

        Checkout(int rentalCode, int customerID, int isbn)
        {
            this.rentalCode = rentalCode;
            this.customerID = customerID;
            this.isbn = isbn;           
        }
    }
}
