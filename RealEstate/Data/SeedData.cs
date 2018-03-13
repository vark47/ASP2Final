using RealEstate.Models;
using System;
using System.Linq;
using RealEstate.Data;
using Microsoft.Extensions.DependencyInjection;

namespace RealEstate.Data
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider services)
        {
            ApplicationDbContext context = services.GetRequiredService<ApplicationDbContext>();
            context.Database.EnsureCreated();
            if (!context.Listings.Any())
            {
                //Image image = new Image { ImageID = 1, URL = "~/images/home1.jpg" }; 
                //context.Images.Add(image);
                //context.SaveChanges();      
                Listing listing = new Listing { Body = "Test.", Rent = 1300.00m, Title="Awesome Bungalow in Detroit" };
                context.Listings.Add(listing);
                //Listing listing2 = new Listing { Body = "A beautiful place to get away from law enforcement.", Rent = 1100.00m, Title = "Another Awesome House" };
               // context.Listings.Add(listing2);


                listing = new Listing { Body = "A beautiful place to get away from law enforcement. TEST@@@@", Rent = 1100.00m, Title = "Another Awesome House" };
                context.Listings.Add(listing);
                //image.Listings.Add(listing);




                context.SaveChanges(); // save the last addition
            }
        }
    }
}

