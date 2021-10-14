using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AmazingBottles12.Data;
using System;
using System.Linq;

namespace AmazingBottles12.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AmazingBottles12Context(
                serviceProvider.GetRequiredService<
                    DbContextOptions<AmazingBottles12Context>>()))
            {
                // Look for any movies.
                if (context.Bottle.Any())
                {
                    return;   // DB has been seeded
                }

                context.Bottle.AddRange(
                    new Bottle
                    {
                        Material = "Plastic",
                        Brand = "Gatorade",
                        Price = 7.99M
                    },

                    new Bottle
                    {
                        Material = "Metal ",
                        Brand = "Nalgene",
                        Price = 8.99M
                    },

                    new Bottle
                    {
                        Material = "Glass",
                        Brand = "Uline",
                        Price = 9.99M
                    },

                    new Bottle
                    {
                        Material = "Polyethylene",
                        Brand = "Lululemon",
                        Price = 3.99M
                    },

                    new Bottle
                    {
                        Material = "Polyvinyl chloride",
                        Brand = "Comotomo",
                        Price = 3.99M
                    },

                    new Bottle
                    {
                        Material = "Polypropylene",
                        Brand = "Medela",
                        Price = 3.99M
                    },

                    new Bottle
                    {
                        Material = "Aluminium",
                        Brand = "NUK",
                        Price = 3.99M
                    },

                    new Bottle
                    {
                        Material = "Stainless Steel",
                        Brand = "AVENT",
                        Price = 3.99M
                    },

                    new Bottle
                    {
                        Material = "Polycarbonate",
                        Brand = "Dr Brown's",
                        Price = 3.99M
                    },

                    new Bottle
                    {
                        Material = "Arsenic",
                        Brand = "Tomme Tippee",
                        Price = 3.99M
                    }

                );
                context.SaveChanges();
            }
        }
    }
}
