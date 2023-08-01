using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DAL.Context
{
    public class CalorieTrackingAppDB: DbContext
    {
        public DbSet<Food> Foods { get; set; }
        public DbSet<Category> Categories { get; set; }    
        public DbSet<User> Users { get; set; }
        public DbSet<Food_User> Foods_Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            
            optionsBuilder.UseSqlServer("Data Source = LAPTOP-59VG7G75\\MSSQLKD15; initial catalog = BurnFatDB; integrated security = true");

           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CalorieTrackingAppDB).Assembly);

        }

    }
}
