using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using IMC.Domain.Interfaces;
using IMC.Domain;

namespace IMC.Application.Paints.Comands.CreatePaint
{
    public class CreatePaintComamdHandler : IRequestHandler<CreatePaintComand, Guid>
    {
        private readonly IRepositoryWrapper repository;

        public CreatePaintComamdHandler(IRepositoryWrapper repository)
        {
            this.repository = repository;
        }


        public async Task<Guid> Handle(CreatePaintComand request, CancellationToken cancellationToken)
        {
            var paint = new Paint
            {
                Id = request.Id,
                Title = request.Title,
                Color = request.Color,
                Row = request.Row,
                Column = request.Column,
                Type = request.Type
            };

            await repository.Piant.CreatePaintAsync(paint);
            await repository.SaveAsync(cancellationToken);

            return paint.Id;
        }
    }
}
