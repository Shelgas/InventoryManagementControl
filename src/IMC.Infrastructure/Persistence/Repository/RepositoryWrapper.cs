using IMC.Domain.Interfaces;

namespace IMC.Infrastructure.Persistence.Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly IMCDbContext _context;
        private IPaintRepository? _paint;

        public RepositoryWrapper(IMCDbContext context)
        {
            this._context = context;
        }

        public IPaintRepository Paint
        {
            get
            {
                if (_paint == null)
                {
                    _paint = new PaintRepository(_context);
                }
                return _paint;
            }
        }

        public IPaintRepository Piant
        {
            get
            {
                if (_paint == null)
                {
                    _paint = new PaintRepository(_context);
                }
                return _paint;
            }
        }

        public async Task SaveAsync(CancellationToken cancellationToken)
        {
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
