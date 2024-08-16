using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.ClassPackage.Persistence
{
    [Table("Books")]
    public class BookTable
    {
        [Column("isbn")]
        [PrimaryKey]
        public int isbn { get; set; }
        [Column("Title")]
        public string title { get; set; }
        [Column("Author")]     
        public string author { get; set; }
        public string genre {  get; set; }
        public bool available { get; set; }
        public int quantity { get; set; }
        
    }
}
