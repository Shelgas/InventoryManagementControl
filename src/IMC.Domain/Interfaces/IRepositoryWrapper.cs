using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC.Domain.Interfaces
{
    public interface IRepositoryWrapper
    {
        IPaintRepository Piant { get;  }
        Task SaveAsync(CancellationToken cancellationToken);
    }
}
