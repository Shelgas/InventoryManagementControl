using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMC.Domain.Interfaces;
using IMC.Domain;
using Microsoft.EntityFrameworkCore;

namespace IMC.Infrastructure.Persistence.Repository
{
    public class PaintRepository : RepositoryBase<Paint>, IPaintRepository
    {

        public PaintRepository(IMCDbContext context)
            : base(context)
        {

        }

        public void CreatePaint(Paint paint)
        {
            Create(paint);
        }

        public void DeletePaint(Paint paint)
        {
            Delete(paint);
        }

        public async Task<IEnumerable<Paint>> GetAllPaintAsync()
        {
            return await FindAll().ToListAsync();
        }

        public async Task<Paint> GetPaintByIdAsync(Guid paintId)
        {
            return await FindByCondition(paint => paint.Id.Equals(paintId))
                .FirstOrDefaultAsync();
        }

        public async Task SaveAsync()
        {
            await context.SaveChangesAsync();
        }

        public void UpdatePaint(Paint paint)
        {
            Update(paint);
        }
    }
}
