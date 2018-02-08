using CaseContactUI.Data.Entiti;
using CaseContactUI.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaseContactUI.Data
{
    public class CaseContactUiDbContext : DbContext
    {
        public CaseContactUiDbContext(DbContextOptions<CaseContactUiDbContext> options) : base(options)
        {



        }
        public DbSet<NewContact> NewContact { get; set; }
        public DbSet<ThirdParty> ThirdParty { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Attorney> Attorney { get; set; }
        public DbSet<ContactInfo> ContactInfo { get; set; }
        public DbSet<OpposingParty> OpposingParty { get; set; }
        public DbSet<ListCaseTypes> ListCaseTypes { get; set; }
        public DbSet<ListGenger> ListGender { get; set; }
        public DbSet<ListWaysToContact> ListWaysToContact { get; set; }
        public DbSet<ListBestTimeToContact> ListBestTimeToContact { get; set; }
      



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
          //  modelBuilder.Entity<OpposingParty>().HasBaseType<Contact>();


            modelBuilder.Entity<NewContact>()
            .HasOne(p => p.ThirdPartyInfo)
            .WithOne(i => i.NewContact)
            .HasForeignKey<ThirdParty>(b => b.Id);

            modelBuilder.Entity<NewContact>()
           .HasOne(p => p.OpposingParty)
           .WithOne(i => i.NewContact)
           .HasForeignKey<OpposingParty>(b => b.Id);


            modelBuilder.Entity<NewContact>()
                .Property(b => b.DateInserted)
                .HasDefaultValueSql("getdate()");
              
            
            modelBuilder.Ignore<Registration>();


            modelBuilder.Entity<NewContact>().ToTable("NewContact");
            modelBuilder.Entity<ThirdParty>().ToTable("ThirdParty");
            modelBuilder.Entity<Address>().ToTable("Address");
            modelBuilder.Entity<Attorney>().ToTable("Attorney");
            modelBuilder.Entity<ContactInfo>().ToTable("ContactInfo");
            modelBuilder.Entity<OpposingParty>().ToTable("OpposingParty");
            modelBuilder.Entity<ListCaseTypes>().ToTable("ListCaseTypes");

        }

    }
}
