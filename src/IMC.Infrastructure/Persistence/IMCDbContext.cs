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
    public class IMCDbContext : DbContext
    {

        public IMCDbContext(DbContextOptions options) 
            : base(options) { }
        
        public DbSet<Paint> Paints { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PaintConfiguration());
            modelBuilder.Entity<Paint>().HasData(
                new Paint { Id = Guid.NewGuid(), Title = "Warboss Green", Type = "Layer", Column = 1 , Row = 1, Color = "#63b521" },
                new Paint { Id = Guid.NewGuid(), Title = "Nuln Oil", Type = "Shade", Column = 1, Row = 2, Color = "#000000" },
                new Paint { Id = Guid.NewGuid(), Title = "Dryad Bark", Type = "Base", Column = 1, Row = 3, Color = "#33312D" },
                new Paint { Id = Guid.NewGuid(), Title = "Screaming Skull", Type = "Layer", Column = 1, Row = 4, Color = "#f0f1ce" }
                );
        }

    }
}
