using Microsoft.EntityFrameworkCore;

namespace IMC.Domain.Interfaces
{
    public interface IPaintsDbContext
    {
        DbSet<Paint> Paints { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken); 
    }
}
