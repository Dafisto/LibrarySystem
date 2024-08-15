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
        private readonly SQLiteAsyncConnection connection;
        public const SQLiteOpenFlags Flags =
            SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create | SQLiteOpenFlags.SharedCache;  // was having issues with multiple tables being created, however when these flags were added, it helped manage more tables

        public LibraryDB(string dbPath)
        {           
            connection = new SQLiteAsyncConnection(dbPath, Flags);
            connection.CreateTableAsync<ClientTable>().Wait(); // client = table name(constructor class for clientTable has parameters for table creation)
            connection.CreateTableAsync<BookTable>().Wait();  // book = book table name (constructor class for bookTable will have all parameters for table creation)
            connection.CreateTableAsync<CheckoutTable>().Wait(); // Checkout = checkout table name (constructor class for chekcoutTable will have the parameters for table creation)
        }
        //The sql commands for client table manipulation

        public Task<int> InsertClientAsync(ClientTable client) // This will save client to client database or update the client
        {
            if(client.customerID != 0)
            {
                return connection.UpdateAsync(client);  //updates existing client at correct spot on table
            }
            else
            {
                return connection.InsertAsync(client); // will insert new client at end of table
            }                            
        }
        public Task<List<ClientTable>> GetAllClientsAsync() 
        {
            return connection.Table<ClientTable>().ToListAsync(); // will return the entire table
        }

        public Task<ClientTable> GetAClientAsync(int customerID) //return a single client row from table
        {
            return connection.Table<ClientTable>().Where(i => i.customerID == customerID).FirstOrDefaultAsync();
        }        
  
        public Task<int> DeleteClientAsync(ClientTable client) // deletes the client from the table
        {
             return connection.DeleteAsync(client); 
        }
       
       

        //These sql commands are to manipulate the BooksTable



        public Task<int> InsertBookAsync(BookTable book) // saves book to the database, works same as InsertClients
        {
            if (book.isbn != 0) 
            {
                return connection.InsertAsync(book); 
            }
            else
            {
                return connection.InsertAsync(book); 
            }
        }

        public Task<List<BookTable>> GetAllBooksAsync() //returns list with all books from the books table
        {
            return connection.Table<BookTable>().ToListAsync(); 
        }

        public Task<BookTable> GetASingleBook(int isbn) // fetches a single book with the matching isbn through as an argument
        {
            return connection.Table<BookTable>().Where(i => i.isbn == isbn).FirstOrDefaultAsync(); // will return the first book found matching in the list
        }

        public Task DeleteBookAsync(BookTable book) // deletes the book from the book database
        {
            return connection.DeleteAsync(book); 
        }




    }
}
