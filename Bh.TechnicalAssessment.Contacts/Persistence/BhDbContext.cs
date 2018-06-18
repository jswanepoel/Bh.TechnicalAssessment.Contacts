using Bh.TechnicalAssessment.Contacts.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bh.TechnicalAssessment.Contacts.Persistence
{
    public class BhDbContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }

        public BhDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}