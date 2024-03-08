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
                                Id = Guid.Parse("12dfbb90-cf1c-4d2a-922c-7350ffca0e6f"),
                                Name = "Speculoos",
                                Description = "Speculoos cream topping, Speculoos Flakes , Speculoos",
                                BasePrice = 11.99m,
                                ImageUrl = "img/donuts/",
                            },
                            new DonutSpecial
                            {
                                Id = Guid.Parse("a20dc365-2946-49c8-8434-76b9fad33a0f"),
                                Name = "Oreo",
                                Description = "Vanilla Napage, Vanilla Oreo bits , Oreo",
                                BasePrice = 9.99m,
                                ImageUrl = "img/donuts/",
                            },
                            new DonutSpecial
                            {
                                Id = Guid.Parse("b9a22a3b-6c9b-45c2-a778-5fadf7821cf4"),
                                Name = "M&M's",
                                Description = "Milk chocolate topping, Crushed M&M's, Chocolate peanut M&M's",
                                BasePrice = 10.50m,
                                ImageUrl = "img/donuts",
                            },
                            new DonutSpecial
                            {
                                Id = Guid.Parse("4b25ff4a-7a9b-46a3-8c73-79dd7ad2a028"),
                                Name = "Nutella",
                                Description = "Nutella topping, Nutella cookie",
                                BasePrice = 12.75m,
                                ImageUrl = "img/donuts/",
                            },
                            new DonutSpecial
                            {
                                Id = Guid.Parse("2b1717c1-a66b-44d3-a15f-0399e09e9baa"),
                                Name = "Country",
                                Description = "White chocolate topping, Caramel rice souffle, Kinder Country",
                                BasePrice = 11.00m,
                                ImageUrl = "img/donuts/",
                            },
                            new DonutSpecial
                            {
                                Id = Guid.Parse("9dbd2105-57f1-4e47-be43-14f069ec4185"),
                                Name = "Kinder Bueno",
                                Description = "Bueno cream topping, Chocolate coulis, Kinder Bueno",
                                BasePrice = 11.50m,
                                ImageUrl = "img/donuts/",
                            },
                            new DonutSpecial
                            {
                                Id = Guid.Parse("0e9b19bd-9c0a-4002-b02b-16c1eb1ad37d"),
                                Name = "Kit Kat",
                                Description = "Milk chocolate topping, Crushed Kit Kat, Kit Kat ",
                                BasePrice = 9.99m,
                                ImageUrl = "img/donuts/",
                            },
                            new DonutSpecial
                            {
                                Id = Guid.Parse("4562c792-4402-4fe8-bcdb-d91dff493efe"),
                                Name = "Natural",
                                Description = "Traditional Donut , Powdered sugar ",
                                BasePrice = 9.99m,
                                ImageUrl = "img/donuts/",
                            },
                            new DonutSpecial
                            {
                                Id = Guid.Parse("63e4f9ad-451e-4b9c-b52f-8a294e83e5d5"),
                                Name = "Glazed",
                                Description = "Traditional Donut , Caramelized sugar ",
                                BasePrice = 9.99m,
                                ImageUrl = "img/donuts/",
                            },
                            new DonutSpecial
                            {
                                Id = Guid.Parse("a6e14ea4-f057-4919-be7e-0090d4a7f26f"),
                                Name = "Chocolat",
                                Description = "Chocolate topping, cookie",
                                BasePrice = 11.00m,
                                ImageUrl = "img/donuts/",
                            }

                        );

            modelBuilder.Entity<Decoration>()
                    .HasData(

                            new Decoration
                            {
                                Id = Guid.Parse("2fb56f52-d68c-4205-935b-b0c0fbfd3608"),
                                Name = "Oreo",
                                Price = 1.99m,
                            },
                            new Decoration
                            {
                                Id = Guid.Parse("8007c9e3-0f4a-4998-bb05-a77c7e05ef14"),
                                Name = "Milk chocolate Sauce",
                                Price = 1.99m,
                            },
                            new Decoration
                            {
                                Id = Guid.Parse("953acd5b-a516-47da-9054-b1b30c6b6716"),
                                Name = "Dark chocolate Sauce",
                                Price = 1.99m,
                            },
                            new Decoration
                            {
                                Id = Guid.Parse("f369abc4-ee2a-418b-8d6e-015f7d32d875"),
                                Name = "Cookie",
                                Price = 1.99m,
                            },
                            new Decoration
                            {
                                Id = Guid.Parse("a6507d7a-7983-4791-b8ce-da7a4dca7e0a"),
                                Name = "Kit Kat",
                                Price = 1.99m,
                            },
                            new Decoration
                            {
                                Id = Guid.Parse("f11ec3e8-6b95-4cec-9434-0b265be8113f"),
                                Name = "Kinder Bueno",
                                Price = 1.99m,
                            },
                            new Decoration
                            {
                                Id = Guid.Parse("e670bbf0-0d8e-4a7d-b37f-14b2fccd9ab9"),
                                Name = "Kinder Country",
                                Price = 1.99m,
                            },
                            new Decoration
                            {
                                Id = Guid.Parse("c888bb18-13e7-4b97-8536-760c1a3851a5"),
                                Name = "M&M's",
                                Price = 1.99m,
                            },
                            new Decoration
                            {
                                Id = Guid.Parse("a1e03fa1-0ad8-4639-8d04-593de8e30f00"),
                                Name = "Speculoos",
                                Price = 1.99m,
                            },
                            new Decoration
                            {
                                Id = Guid.Parse("8f5d524a-5b11-4f52-a1ab-9d426dd7d988"),
                                Name = "Nutella",
                                Price = 1.99m,
                            },
                            new Decoration
                            {
                                Id = Guid.Parse("dfe11920-410a-4597-be5c-a75f1c0de696"),
                                Name = "White chocolate Sauce",
                                Price = 1.99m,
                            },
                            new Decoration
                            {
                                Id = Guid.Parse("67fffa43-5707-4731-82b0-5da038317510"),
                                Name = "Milka",
                                Price = 1.99m,
                            }

                      );
        }
    }
}
