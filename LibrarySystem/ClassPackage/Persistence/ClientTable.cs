using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace LibrarySystem.ClassPackage.Persistence
{
    public class ClientTable
    {
        [PrimaryKey, AutoIncrement]
        public int customerID { get; set; }
        public string firstName { get; set; }
        public string lastName {  get; set; }
        public string city { get; set; }
    }
}
