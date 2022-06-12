using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC.Application.Paints.Comands.CreatePaint
{
    public class CreatePaintComand : IRequest<Guid>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }
        public string? Type { get; set; }
        public string Color { get; set; }
    }
}
