using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.ClassPackage.Persistence
{
    public class BookTable
    {
        [PrimaryKey]
        public int isbn { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string genre {  get; set; }
        public bool available { get; set; }
        public int quantity { get; set; }
        
    }
}
