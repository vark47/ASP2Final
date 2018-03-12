/*using FinalProj.Models;
using System;
using System.Linq;
using FinalProj.Data;

namespace FinalProj.Data
{
    public static class SeedData
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Listings.Any())
            {
                return;   // DB has been seeded
            }




            var images = new Image[]
            {
            new Image{ImageID = 1, URL = "~/images/home1.jpg"},
            new Image{ImageID = 2, URL = "~/images/home2.jpg"},
            new Image{ImageID = 3, URL = "~/images/home3.jpg"},
            new Image{ImageID = 4, URL = "~/images/home4.jpg"},
            new Image{ImageID = 5, URL = "~/images/home5.jpg"},
            new Image{ImageID = 6, URL = "~/images/home6.jpg"},
            };
            foreach (Image i in images)
            {
                context.Images.Add(i);
            }
            context.SaveChanges();
        

            var listings = new Listing[]
          {
            new Listing{ Body="This house ain't hardly had no murders in it.", ImageID = 1, Rent = 1300.00m},
            new Listing{ Body="Great for hiding dead bodies", ImageID = 2, Rent = 1600.00m},
            new Listing{ Body="Why are you even still looking at our listings at this point you sick person?", ImageID = 3, Rent = 1100.00m}
           };
            foreach (Listing s in listings)
            {
                context.Listings.Add(s);
            }
            context.SaveChanges();

        }


    }

    }

    */