using CaseContact.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewContactAPI.Data
{
    public class NewContactDbContext : DbContext
    {
        public NewContactDbContext(DbContextOptions<NewContactDbContext> options) : base (options)
        {

        }
        public DbSet<CaseType> CaseType { get; set; }
        public DbSet<NewContact> NewContact { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<ContactTime> ContactTime { get; set; }
        public DbSet<ContactType> ContactType { get; set; }
        public DbSet<WaysToContact> WaysToContact { get; set; }

    }
}
