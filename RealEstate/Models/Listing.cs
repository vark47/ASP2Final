using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RealEstate.Models;


namespace RealEstate.Models
{
    public class Listing
    {
        public int ID { get; set; }
        public int ImageID { get; set; }
        public string Body { get; set; }
        public string Title { get; set; }
        public decimal Rent { get; set; }
        

    }
}
