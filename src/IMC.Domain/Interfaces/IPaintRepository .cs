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
        Task<IEnumerable<Paint>> GetPaintByNameAsync(string name);
        Task<Paint> GetSinglepPaint(Guid id);

        Task CreatePaintAsync(Paint paint);
        void UpdatePaint(Paint paint);
        void DeletePaint(Paint paint);
    }
}
