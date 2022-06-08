using IMC.Domain;
using IMC.Domain.Interfaces;
using IMC.Infrastructure.Persistence.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC.Infrastructure.Persistence
{
    public class IMCDbContext : DbContext, IPaintsDbContext
    {

        public IMCDbContext(DbContextOptions options) 
            : base(options) { }
        
        public DbSet<Paint> Paints { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PaintConfiguration());
            modelBuilder.Entity<Paint>().HasData(
                new Paint { });
        }

    }
}
