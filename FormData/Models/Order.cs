using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HTMLHelpers.Models
{
    public class Order
    {
        public Product Prod { get; set; }
        public int Qty { get; set; }


        public string Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public string User { get; set; }
        public string Address { get; set; }
    }
}