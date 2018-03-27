using System;
using System.Collections.Generic;
using System.Data.Entity;
using EntityFramework;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentHouseManager.Project.DAL.Models;

namespace RentHouseManager.Project.DAL
{
    public class DBContext : DbContext
    {
        //Put database context inside this class
        public DBContext() : base("name=RentHouseConnectionString")
        {
        }

        public DbSet<UserInfo> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserInfo>().ToTable("User");
            modelBuilder.Entity<Account>().ToTable("Account");
        }
    }
}
