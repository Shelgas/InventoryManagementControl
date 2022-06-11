using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC.Domain.Interfaces
{
    public interface IPaintRepository : IRepositoryBase<Paint>
    {
        Task<IEnumerable<Paint>> GetAllPaintAsync();
        Task<Paint> GetPaintByIdAsync(Guid paintId);

        void CreatePaint(Paint paint);
        void UpdatePaint(Paint paint);
        void DeletePaint(Paint paint);

        Task SaveAsync();
    }
}
