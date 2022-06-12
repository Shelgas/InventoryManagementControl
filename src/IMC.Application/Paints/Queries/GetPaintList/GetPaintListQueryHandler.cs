using MediatR;
using IMC.Domain;
using Microsoft.EntityFrameworkCore;
using IMC.Domain.Interfaces;

namespace IMC.Application.Paints.Queries.GetPaintList
{
    public class GetPaintListQueryHandler : IRequestHandler<GetPaintListQuery, IEnumerable<Paint>>
    {
        private readonly IRepositoryWrapper _repository;

        public GetPaintListQueryHandler(IRepositoryWrapper repository)
        {
            _repository = repository;
        }


        public async Task<IEnumerable<Paint>> Handle(GetPaintListQuery request,
            CancellationToken cancellationToken)
        {
            var paintQuery = await _repository.Piant.GetAllPaintAsync();
            return paintQuery;
        }
    }
}
