using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace LibrarySystem.ClassPackage.Domain
{
    internal class Client
    {
        //getters and setters
        private int _customerID;
        private string _firstName;
        private string _lastName;
        private string _city;
        
        public int CustomerID
        {
            get { return _customerID; }
            set { _customerID = value; }
        }
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        public Client(int customerID, string firstName, string lastName, string city)
        {
            this.CustomerID = customerID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.City = city;
        }  
       
    }
}
