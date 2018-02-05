using CaseContact.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CaseContact.ViewModels;

namespace CaseContact.Data
{
    public class CaseTypeDbContext : DbContext
    {
        public CaseTypeDbContext(DbContextOptions<CaseTypeDbContext> options) :  base (options)
        {
          
            

        }
        public DbSet<CaseType> CaseType { get; set; }
        public DbSet<NewContact> NewContact { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<ContactTime> ContactTime { get; set; }
        public DbSet<ContactType> ContactType { get; set; }
        public DbSet<WaysToContact> WaysToContact { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<CaseType>().ToTable("CaseType");
            modelBuilder.Entity<NewContact>().ToTable("NewContact");
            modelBuilder.Entity<Gender>().ToTable("Gender");
            modelBuilder.Entity<ContactTime>().ToTable("ContactTime");
            modelBuilder.Entity<WaysToContact>().ToTable("WaysToContact");




        }


    }
    }
