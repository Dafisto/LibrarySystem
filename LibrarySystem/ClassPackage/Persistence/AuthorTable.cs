using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace LibrarySystem.ClassPackage.Persistence
{
    [Table("Author")]
    internal class AuthorTable
    {
        [PrimaryKey]
        private string author { get; set; }
            

    }
}
