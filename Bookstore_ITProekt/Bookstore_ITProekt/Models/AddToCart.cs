using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bookstore_ITProekt.Models
{
    public class AddToCart
    {
        public int cartId { get; set; }
        public int bookId { get; set; }
        public List<Book> books { get; set; }
        public AddToCart()
        {
            books = new List<Book>();
        }
    }
}