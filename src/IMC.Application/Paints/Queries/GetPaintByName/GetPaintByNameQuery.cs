using MediatR;
using IMC.Domain;

namespace IMC.Application.Paints.Queries.GetPaintByName
{
    public class GetPaintByNameQuery : IRequest<IList<Paint>>
    {
         public string Title { get; set; }  
    }
}
