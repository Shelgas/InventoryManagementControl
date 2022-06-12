﻿using MediatR;
using IMC.Domain;

namespace IMC.Application.Paints.Queries.GetPaintList
{
    public class GetPaintListQuery : IRequest<IList<Paint>>
    {
        public Guid Id { get; set; }
    }
}
