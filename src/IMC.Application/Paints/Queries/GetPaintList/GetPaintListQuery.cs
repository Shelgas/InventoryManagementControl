using MediatR;
using IMC.Domain;

namespace IMC.Application.Paints.Queries.GetPaintList
{
    public class GetPaintListQuery : IRequest<IList<Paint>>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }
        public string? Type { get; set; }
        public string Color { get; set; }
    }
}
