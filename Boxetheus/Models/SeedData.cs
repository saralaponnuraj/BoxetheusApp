using Boxetheus.Data;
using Microsoft.EntityFrameworkCore;

namespace Boxetheus.Models
{
    public class SeedData
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BoxetheusContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<BoxetheusContext>>()))
            {
                // Look for any movies.
                if (context.BoxView.Any())
                {
                    return;   // DB has been seeded
                }
                context.BoxView.AddRange(
                    new BoxView
                    {
                        Brand = "Boxify",
                        OrderDate = DateTime.Parse("2024-02-07"),
                        Category = "Cosmetic Box",
                        Design = "Floral Design",
                        Shape = "Oval",
                        Size = "Medium",
                        Quantity = 10,
                        //Color = "Pink",
                        Price = 277.50M
                    },
            new BoxView
            {
                Brand = "CargoCove",
                OrderDate = DateTime.Parse("2024-02-10"),
                Category = "Toy Box",
                Design = "Cartoon Characters",
                Shape = "Custom Shape",
                Size = "Large",
                Quantity = 15,
                //Color = "Gray",
                Price = 80.49M
            },
            new BoxView
            {
                Brand = "FlexiBox",
                OrderDate = DateTime.Parse("2024-02-14"),
                Category = "Shipping Box",
                Design = "Stripes",
                Shape = "Standard",
                Size = "Abstract Art",
                Quantity = 100,
                //Color = "Beige",
                Price = 259.59M
            },
            new BoxView
            {
                Brand = "PackMaster",
                OrderDate = DateTime.Parse("2024-02-03"),
                Category = "Electronic Product Box",
                Design = "Geometric Patterns",
                Shape = "Extra Large",
                Size = "Vintage Patterns",
                Quantity = 12,
                //Color = "Brown",
                Price = 183.29M
            },
            new BoxView
            {
                Brand = "CrateCraze",
                OrderDate = DateTime.Parse("2024-02-08"),
                Category = "Food Packaging Box",
                Design = "Stripes",
                Shape = "Rectangular",
                Size = "Large",
                Quantity = 50,
                //Color = "Blue",
                Price = 53.97M
            },
            new BoxView
            {
                Brand = "BoxLuxe",
                OrderDate = DateTime.Parse("2024-02-05"),
                Category = "Jewelry Box",
                Design = "Minimalist Design",
                Shape = "Square",
                Size = "Medium",
                Quantity = 8,
                //Color = "Red Violet",
                Price = 250.39M
            },
            new BoxView
            {
                Brand = "SturdyBox",
                OrderDate = DateTime.Parse("2024-02-01"),
                Category = "Gift Box",
                Design = "Minimalist Design",
                Shape = "Oval",
                Size = "Small",
                Quantity = 2,
                //Color = "Black",
                Price = 105.50M
            },
            new BoxView
            {
                Brand = "SecurePack",
                OrderDate = DateTime.Parse("2024-01-05"),
                Category = "Moving Box",
                Design = "Stripes",
                Shape = "Square",
                Size = "Extra Large",
                Quantity = 6,
                //Color = "Beige",
                Price = 103.15M
            },
            new BoxView
            {
                Brand = "PrimePack",
                OrderDate = DateTime.Parse("2024-01-30"),
                Category = "Storage Box",
                Design = "Polka Dots",
                Shape = "Square",
                Size = "Extra Large",
                Quantity = 4,
                //Color = "Brown",
                Price = 83.09M
            },
              new BoxView
              {
                  Brand = "PrimePack2",
                  OrderDate = DateTime.Parse("2024-02-12"),
                  Category = "Storage Box",
                  Design = "Stripes",
                  Shape = "Rectangular",
                  Size = "Large",
                  Quantity = 4,
                  //Color = "Black",
                  Price = 83.09M
              }

                );
                context.SaveChanges();
            }
        }
    }
}
        
    
