using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace LibrarySystem.ClassPackage.Persistence
{
    [Table("Client")]
    public class ClientTable
    {
        [Column("customerID")]
        [PrimaryKey, AutoIncrement]
        public int customerID { get; set; }
        [Column("firstName")]
        [NotNull]
        public string firstName { get; set; }
        [Column("lastName")]
        [NotNull]
        public string lastName {  get; set; }
        [Column("city")]
        [NotNull]
        public string city { get; set; }
    }
}
