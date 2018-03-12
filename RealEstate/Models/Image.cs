using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.Models
{
    public class Image
    {
        public int ImageID { get; set; }
        public string URL { get; set; }
        public ICollection<Listing> Listings { get; set; }
    }
}
