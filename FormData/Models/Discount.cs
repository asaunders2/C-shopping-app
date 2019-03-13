using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HTMLHelpers.Models
{
    public class Discount
    {
        internal int id;

        public string Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Discount Disc { get; set; }


    }
}