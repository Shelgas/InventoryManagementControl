using MediatR;
using IMC.Domain;
using Microsoft.EntityFrameworkCore;
using IMC.Domain.Interfaces;

namespace IMC.Application.Paints.Queries.GetPaintByName
{
    public class GetPaintByNameQueryHandle : IRequestHandler<GetPaintByNameQuery, IEnumerable<Paint>>
    {
        private readonly IRepositoryWrapper repository;

        public GetPaintByNameQueryHandle(IRepositoryWrapper repository)
        {
            this.repository = repository;
        }

        public async Task<IEnumerable<Paint>> Handle(GetPaintByNameQuery request, CancellationToken cancellationToken)
        {
            return await repository.Piant.GetPaintByNameAsync(request.Title);
        }
    }
}
