using IMC.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC.Application.Paints.Queries.GetSinglePaint
{
    public class GetSinglePaintQuery : IRequest<Paint>
    {
        public Guid Id { get; set; }
    }
}
