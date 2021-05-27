using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Teama.Application.Queries.RequestTypes;
using Teama.Domain.Entities;
using Teama.Infrastructure.Persistence;
namespace Teama.Application.Queries.RequestTypes
    {
        public class GetAllRequestTypesQueryRequestHandler : IRequestHandler<GetAllRequestTypesQueryRequest,IEnumerable < RequestType>>
        {
            private readonly TeamaContext  _TeamaContext;
            public GetAllRequestTypesQueryRequestHandler(TeamaContext teamaContext)
            {
                _TeamaContext = teamaContext;

            }
               public async Task<IEnumerable < RequestType>> Handle(GetAllRequestTypesQueryRequest request, CancellationToken cancellationToken)
             {
             var requestTypes = _TeamaContext.RequestTypes.ToListAsync();
             if (requestTypes == null)
             {
                throw new ApplicationException();
             }
              return await requestTypes;
              }
        }
    }
