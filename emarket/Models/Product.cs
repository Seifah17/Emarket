using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;


namespace emarket.Models
{
    public class Product
    {
        public int id { get; set; }

        [Display(Name = "Product Name")]
        public string name { get; set; }

        [Display(Name = "Img")]
        public string image { get; set; }

        [Display(Name = "Price")]
        public float price { get; set; }

        [Display(Name = "Description")]
        public string description { get; set; }
        public Category category { get; set; }
        public int CategoryId { get; set; }
    }
}