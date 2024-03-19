using DonutShop.Models;
using Microsoft.EntityFrameworkCore;

namespace DonutShop.Data
{
    public class DonutShopContext : DbContext
    {
        public DonutShopContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Donut> Donuts { get; set; }

        public DbSet<DonutSpecial> Specials { get; set; }

        public DbSet<Decoration> Decorations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuring a many-to-many special -> topping relationship that is friendly for serialization
            modelBuilder.Entity<DonutDecoration>().HasKey(dnd => new { dnd.DonutId, dnd.DecorationId });
            modelBuilder.Entity<DonutDecoration>().HasOne<Donut>().WithMany(don => don.Decorations);
            modelBuilder.Entity<DonutDecoration>().HasOne(dnd => dnd.Decoration).WithMany();

            modelBuilder.Entity<DonutSpecial>()
                    .HasData(
                            new DonutSpecial
                            {
                                Id = 1,
                                Name = "Speculoos",
                                Description = "Speculoos cream topping, Speculoos Flakes , Speculoos",
                                BasePrice = 11.99m,
                                ImageUrl = "img/donuts/speculos.png",
                            },
                            new DonutSpecial
                            {
                                Id = 2,
                                Name = "Oreo",
                                Description = "Vanilla Napage, Vanilla Oreo bits , Oreo",
                                BasePrice = 9.99m,
                                ImageUrl = "img/donuts/oreo.png",
                            },
                            new DonutSpecial
                            {
                                Id = 3,
                                Name = "M&M's",
                                Description = "Milk chocolate topping, Crushed M&M's, Chocolate peanut M&M's",
                                BasePrice = 10.50m,
                                ImageUrl = "img/donuts/mms.png",
                            },
                            new DonutSpecial
                            {
                                Id = 4,
                                Name = "Nutella",
                                Description = "Nutella topping, Nutella cookie",
                                BasePrice = 12.75m,
                                ImageUrl = "img/donuts/nutella.png",
                            },
                            new DonutSpecial
                            {
                                Id = 5,
                                Name = "Kinder Country",
                                Description = "White chocolate topping, Caramel rice souffle, Kinder Country",
                                BasePrice = 11.00m,
                                ImageUrl = "img/donuts/kinder_country.png",
                            },
                            new DonutSpecial
                            {
                                Id = 6,
                                Name = "Kinder Bueno",
                                Description = "Bueno cream topping, Chocolate coulis, Kinder Bueno",
                                BasePrice = 11.50m,
                                ImageUrl = "img/donuts/bueno.png",
                            },
                            new DonutSpecial
                            {
                                Id = 7,
                                Name = "Kit Kat",
                                Description = "Milk chocolate topping, Crushed Kit Kat, Kit Kat ",
                                BasePrice = 9.99m,
                                ImageUrl = "img/donuts/kitkat.png",
                            },
                            new DonutSpecial
                            {
                                Id = 8,
                                Name = "Natural",
                                Description = "Traditional Donut , Powdered sugar ",
                                BasePrice = 9.99m,
                                ImageUrl = "img/donuts/nature.png",
                            },
                            new DonutSpecial
                            {
                                Id = 9,
                                Name = "Glazed",
                                Description = "Traditional Donut , Caramelized sugar ",
                                BasePrice = 9.99m,
                                ImageUrl = "img/donuts/sugarGlazed.png",
                            },
                            new DonutSpecial
                            {
                                Id = 10,
                                Name = "Chocolat",
                                Description = "Chocolate topping, cookie",
                                BasePrice = 11.00m,
                                ImageUrl = "img/donuts/chocolat.png",
                            }

                        );

            modelBuilder.Entity<Decoration>()
                    .HasData(

                            new Decoration
                            {
                                Id = 1,
                                Name = "Oreo",
                                Price = 1.99m,
                            },
                            new Decoration
                            {
                                Id = 2,
                                Name = "Milk chocolate Sauce",
                                Price = 1.99m,
                            },
                            new Decoration
                            {
                                Id = 3,
                                Name = "Dark chocolate Sauce",
                                Price = 1.99m,
                            },
                            new Decoration
                            {
                                Id = 4,
                                Name = "Cookie",
                                Price = 1.99m,
                            },
                            new Decoration
                            {
                                Id = 5,
                                Name = "Kit Kat",
                                Price = 1.99m,
                            },
                            new Decoration
                            {
                                Id = 6,
                                Name = "Kinder Bueno",
                                Price = 1.99m,
                            },
                            new Decoration
                            {
                                Id = 7,
                                Name = "Kinder Country",
                                Price = 1.99m,
                            },
                            new Decoration
                            {
                                Id = 8,
                                Name = "M&M's",
                                Price = 1.99m,
                            },
                            new Decoration
                            {
                                Id = 9,
                                Name = "Speculoos",
                                Price = 1.99m,
                            },
                            new Decoration
                            {
                                Id = 10,
                                Name = "Nutella",
                                Price = 1.99m,
                            },
                            new Decoration
                            {
                                Id = 11,
                                Name = "White chocolate Sauce",
                                Price = 1.99m,
                            },
                            new Decoration
                            {
                                Id = 12,
                                Name = "Milka",
                                Price = 1.99m,
                            }

                      );
        }
    }
}
