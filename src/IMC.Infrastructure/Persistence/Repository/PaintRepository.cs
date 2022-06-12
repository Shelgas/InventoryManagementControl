﻿using System;
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

        public async Task CreatePaintAsync(Paint paint)
        {
            await CreateAsync(paint);
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

        public void UpdatePaint(Paint paint)
        {
            Update(paint);
        }
    }
}