using VideoShop.Pocos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace VideoShop.EFDataAcccess
{
    public class VideoShopContext : DbContext
    {
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            config.AddJsonFile(path, false);
            var root = config.Build();
            string _connStr = root.GetSection("ConnectionStrings").GetSection("DataConnection").Value;
            optionsBuilder.UseSqlServer(_connStr);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<BorrowerPoco> BorrowerPocos { get; set; }
        public DbSet<VideoPoco> VideoPocos { get; set; }
    }
}
