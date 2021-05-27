using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Teama.Application.Queries.Positions;
using Teama.Domain.Entities;
using Teama.Infrastructure.Persistence;
namespace Teama.Application.Queries.Positions
    {
        public class GetAllPositionsQueryRequestHandler : IRequestHandler<GetAllPositionsQueryRequest,IEnumerable < Position>>
        {
            private readonly TeamaContext  _TeamaContext;
            public GetAllPositionsQueryRequestHandler(TeamaContext teamaContext)
            {
                _TeamaContext = teamaContext;

            }
               public async Task<IEnumerable < Position>> Handle(GetAllPositionsQueryRequest request, CancellationToken cancellationToken)
             {
             var positions = _TeamaContext.Positions.ToListAsync();
             if (positions == null)
             {
                throw new ApplicationException();
             }
              return await positions;
              }
        }
    }
