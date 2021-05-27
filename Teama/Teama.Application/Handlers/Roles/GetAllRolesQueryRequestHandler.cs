using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Teama.Application.Queries.Roles;
using Teama.Domain.Entities;
using Teama.Infrastructure.Persistence;
namespace Teama.Application.Queries.Roles
    {
        public class GetAllRolesQueryRequestHandler : IRequestHandler<GetAllRolesQueryRequest,IEnumerable < Role>>
        {
            private readonly TeamaContext  _TeamaContext;
            public GetAllRolesQueryRequestHandler(TeamaContext teamaContext)
            {
                _TeamaContext = teamaContext;

            }
               public async Task<IEnumerable < Role>> Handle(GetAllRolesQueryRequest request, CancellationToken cancellationToken)
             {
             var roles = _TeamaContext.Roles.ToListAsync();
             if (roles == null)
             {
                throw new ApplicationException();
             }
              return await roles;
              }
        }
    }
