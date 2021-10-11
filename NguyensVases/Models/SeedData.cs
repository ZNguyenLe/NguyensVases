using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NguyensVases.Data;
using System;
using System.Linq;

namespace NguyensVases.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new NguyensVasesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<NguyensVasesContext>>()))
            {
                //Look for any Vases and if there is no data inside the table, the content below will replace it.
                if (context.Vases.Any())
                {
                    return; // DB has been seeded
                }

                context.Vases.AddRange(
                    new Vases
                    {
                        Name = "Branda Glass Table Vase",
                        Material = "Glass",
                        Color = "Blue",
                        Weight = "20lb",
                        Rating = "4",
                        Price = 285.99M
                    },
                    new Vases
                    {
                        Name = "Baccarat Louxor Vase",
                        Material = "Glass",
                        Color = "Red",
                        Weight = "6lb",
                        Rating = "3",
                        Price = 1080.35M
                    },
                    new Vases
                    {
                        Name = "Leewadee Tall Big Floor Standing Vase",
                        Material = "Wood",
                        Color = "Brown",
                        Weight = "15lb",
                        Rating = "4.5",
                        Price = 259.99M
                    },
                    new Vases
                    {
                        Name = "Nachtmann Dancing Stars Bossa Nova",
                        Material = "Crystal",
                        Color = "Clear White",
                        Weight = "15lb",
                        Rating = "4",
                        Price = 104.00M
                    },
                    new Vases
                    {
                        Name = "Marquis By Waterford Sparkle 9 Vase",
                        Material = "Crystal",
                        Color = "Transparent",
                        Weight = "5.5lb",
                        Rating = "4.5",
                        Price = 98.06M
                    },
                    new Vases
                    {
                        Name = "Memorial Cemetery Flower Vase",
                        Material = "Plastic",
                        Color = "Black",
                        Weight = "12lb",
                        Rating = "4",
                        Price = 68.90M
                    },
                    new Vases
                    {
                        Name = "Novelty Mfg Co 5041 Metal Cone Cemetery Vase",
                        Material = "Metal",
                        Color = "Green",
                        Weight = "5lb",
                        Rating = "4.5",
                        Price = 16.62M
                    },
                    new Vases
                    {
                        Name = "Rivet Modern Geometric Pattern Decorative Stoneware Vase",
                        Material = "Stoneware",
                        Color = "White",
                        Weight = "3lb",
                        Rating = "3",
                        Price = 53.15M
                    },
                    new Vases
                    {
                        Name = "Samawai Modern Ceramic Vase (Set of 2)",
                        Material = "Plastic",
                        Color = "White",
                        Weight = "2lb",
                        Rating = "4",
                        Price = 49.50M
                    },
                    new Vases
                    {
                        Name = "Hosley's 18' High Silver Color Metal Floor vase",
                        Material = "Metal",
                        Color = "Silver",
                        Weight = "10lb",
                        Rating = "5",
                        Price = 38.62M
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
