using VideoShop.Pocos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace VideoShop.EFDataAcccess
{
    public static class ModelBuilderSeed
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VideoPoco>().HasData(
                new VideoPoco
                {
                    Id = Guid.NewGuid(),
                    VideoName = "The Witcher",
                    ReleaseDate = new DateTime(2010, 04, 23),
                    Borrower = new BorrowerPoco
                    {
                        Id = Guid.NewGuid(),
                        BorrowerName = "Jessie Winston",
                        DOB = new DateTime(1992, 09, 16)
                    }
                },
                 new VideoPoco
                 {
                     Id = Guid.NewGuid(),
                     VideoName = "Contagion",
                     ReleaseDate = new DateTime(2011, 07, 23),
                     Borrower = new BorrowerPoco
                     {
                         Id = Guid.NewGuid(),
                         BorrowerName = "Hazel Jane",
                         DOB = new DateTime(1992, 09, 16)
                     }
                 },
                 new VideoPoco
                 {
                     Id = Guid.NewGuid(),
                     VideoName = "The Last of Us",
                     ReleaseDate = new DateTime(2020, 01, 23),
                     Borrower = new BorrowerPoco
                     {
                         Id = Guid.NewGuid(),
                         BorrowerName = "Chris Joe",
                         DOB = new DateTime(1992, 09, 16)
                     }
                 }
            );
        }
    }
}
