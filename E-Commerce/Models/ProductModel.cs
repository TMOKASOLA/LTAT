using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Commerce.Models
{
    public class ProductModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string FullInformation { get; set; }
        public string imageUrl { get; set; }

        public static explicit operator List<object>(ProductModel v)
        {
            throw new NotImplementedException();
        }
    }
}