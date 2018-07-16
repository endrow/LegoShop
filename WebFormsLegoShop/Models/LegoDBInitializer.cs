using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebFormsLegoShop.Models
{
    public class LegoDBInitializer : DropCreateDatabaseIfModelChanges<LegoDBContext>
    {
        protected override void Seed(LegoDBContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Pirates",
                    Description = "Being a pirate is scary and dangerous, but it can be awesome, too!"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Kingdoms",
                    Description = "Build castles or destroy them! Its your choice to be a brave knight or an evil king!"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "City",
                    Description = "You can be a policeman, a firefighter, or even a robber if you want! Will you build a great city, or set one on fire?"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Racers",
                    Description = "Be faster than a thunderbolt as a real LEGO racer!"
                },
            };

            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product> {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Caribbean Pirates",
                    Description = "Have you ever wanted to be a pirate? Well, now you can be one!",
                    ImagePath="/Images/Products/pirate.jpg",
                    UnitPrice = 29.50,
                    CategoryID = 1
               },
                new Product
                {
                    ProductID = 2,
                    ProductName = "Knight of the Night",
                    Description = "Play as an evil knight and conquer the world! Its yours if you can take it!",
                    ImagePath="/Images/Products/nightknight.jpg",
                    UnitPrice = 4.95,
                     CategoryID = 2
               },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Brothers in Arms",
                    Description = "These shiny knights are there to defend the world! But can you defend them?",
                    ImagePath="/Images/Products/knights.jpg",
                    UnitPrice = 19.99,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Firefighter",
                    Description = "There is a burning building in the city? Well, now there isn't!",
                    ImagePath="/Images/Products/firefighter.jpg",
                    UnitPrice = 8.95,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "Policeman",
                    Description = "Ever wanted to be a police officer? Well, now you can be one!",
                    ImagePath="/Images/Products/police.jpg",
                    UnitPrice = 14.95,
                    CategoryID = 3
                },
            };

            return products;
        }
    }

}