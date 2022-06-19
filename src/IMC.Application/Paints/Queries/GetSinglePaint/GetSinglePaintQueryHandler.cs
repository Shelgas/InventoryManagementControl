using IMC.Domain;
using IMC.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC.Application.Paints.Queries.GetSinglePaint
{
    public class GetSinglePaintQueryHandler : IRequestHandler<GetSinglePaintQuery, Paint>
    {
        private readonly IRepositoryWrapper repository;

        public GetSinglePaintQueryHandler(IRepositoryWrapper repository)
        {
            this.repository = repository;
        }
        public async Task<Paint> Handle(GetSinglePaintQuery request, CancellationToken cancellationToken)
        {
            return await repository.Piant.GetSinglepPaint(request.Id);
        }
    }
}
