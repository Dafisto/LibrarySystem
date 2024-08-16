using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.ClassPackage.Domain
{
    internal class Books        
    {
        internal int isbn;
        internal string title;
        internal string author;
        internal int quantity;
        internal bool available;
        
      public int Isbn
        {
            get {  return isbn; }
            set { isbn = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set {  quantity = value; }
        }
        public bool Available
        {
            get { return available; }
            set { available = value; }
        }
        public Books(int isbn, string title, string author, int quantity, bool available)
        {
            this.isbn = isbn;
            this.title = title;
            this.author = author;
            this.quantity = quantity;
            this.available = available;
        }
        public override string ToString()
        {
            if (Isbn == null)
            {
                return "";
            }
            return $"{Isbn}, {Title}, {Author}, {Quantity}, {Available}";
        }
    }
}
