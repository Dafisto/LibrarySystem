using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarySystem.ClassPackage.Domain;




namespace LibrarySystem.ClassPackage.Persistence
{
    public class LibraryDB
    {
        private readonly SQLiteConnection connection;
        public LibraryDB(string dbPath)
        {
            connection = new SQLiteConnection(dbPath);
            connection.CreateTable<ClientTable>();
            connection.CreateTable<BookTable>();
            connection.CreateTable<CheckoutTable>();
        }
        //The sql commands for client table manipulation

        public void InsertClient(ClientTable client) // saves the item to the database
        {
            if (client.customerID != 0) // if the item already exists
            {
                connection.Insert(client); // updates the item
            }
            else
            {
                connection.Insert(client); // inserts the item
            }
        }
        public List<ClientTable> GetClients() // Item = table name
        {
            return connection.Table<ClientTable>().ToList(); // fetches all data and returns the items as a list
        }
        public void DeleteClient(ClientTable client) // deletes the item from the database
        {
             connection.Delete(client); // deletes the item
        }
       
        public  ClientTable GetClient(int customerID) // fetches a single item with the matching id that is passed into the method
        {
            return connection.Table<ClientTable>().Where(i => i.customerID == customerID).FirstOrDefault(); // returns the first or the default data
        }

        //These sql commands are to manipulate the BooksTable



        public void InsertBook(BookTable book) // saves the item to the database
        {
            if (book.isbn != 0) // if the item already exists
            {
                connection.Insert(book); // updates the item
            }
            else
            {
                connection.Insert(book); // inserts the item
            }
        }
        public List<BookTable> GetBooks() // Item = table name
        {
            return connection.Table<BookTable>().ToList(); // fetches all data and returns the items as a list
        }
        public void DeleteBook(BookTable book) // deletes the item from the database
        {
            connection.Delete(book); // deletes the item
        }

        public BookTable GetBook(int isbn) // fetches a single item with the matching id that is passed into the method
        {
            return connection.Table<BookTable>().Where(i => i.isbn == isbn).FirstOrDefault(); // returns the first or the default data
        }




    }
}
