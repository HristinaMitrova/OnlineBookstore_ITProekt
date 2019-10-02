using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bookstore_ITProekt.Models
{
    public class Book
    {
        [Key]
        public int ID { set; get; }
        [Required]
        public string Name { set; get; }
        [Required]
        [Range(0, 2020, ErrorMessage = "The year must be a positive number!")]
        public int Year { set; get; }
        [Required]
        [Range(0,9999,ErrorMessage="The price must be a psitive number!")]
        public float Price { set; get; }
        [Required]
        [Display(Name = "Image URL")]
        public string ImgUrl { set; get; }
        public string Description { set; get; }
        public virtual Author Author {set;get;}
        public virtual ICollection<PublishingHouse> PublishingHouses { set; get; }

        
        public Book()
        {
            PublishingHouses = new List<PublishingHouse>();
        }
    }
}