using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace LibrarySystem.ClassPackage.Persistence
{
    
    internal class CheckoutTable
    {
        [PrimaryKey, AutoIncrement]
        public int rentalCode { get; set; }        
        public int customerID {  get; set; }
        public int isbn { get; set; }
    }
}
