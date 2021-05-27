using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Teama.Domain.Entities;

namespace Teama.Application.Queries.Positions
    {
        public class GetAllPositionsQueryRequest : IRequest<IEnumerable<Position>>
        {
        }
    }
