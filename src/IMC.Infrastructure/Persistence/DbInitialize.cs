using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC.Infrastructure.Persistence
{
    public static class DbInitialize
    {
        public static void Initialize(IMCDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
