using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Bookstore_ITProekt.Models
{
    public class BookstoreDB:DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<PublishingHouse> PublishHouses { get; set; }
        public DbSet<Author> Authors{ get; set; }

        public BookstoreDB():base ("BookstoreDB")
        {
        }
        public static BookstoreDB Create()
        {
            return new BookstoreDB();
        }
    }
}