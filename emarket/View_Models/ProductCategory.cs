using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using emarket.Models;

namespace emarket.View_Models
{
    public class ProductCategory
    {
        public IEnumerable<Category> categories { get; set; }
        public Product product { get; set; }
    }
}