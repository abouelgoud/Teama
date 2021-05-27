using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Teama.Application.Queries.Roles;
using Teama.Domain.Entities;
using Teama.Infrastructure.Persistence;

namespace Teama.Application.Handlers.Roles
{
    public class GetAllRolesQueryHandler : IRequestHandler<GetAllRolesQueryRequest, IEnumerable<Role>>
     {
        private readonly TeamaContext _TeamaContext;
        public GetAllRolesQueryHandler(TeamaContext teamaContext)
        {
            _TeamaContext = teamaContext;

        }
        public async Task<IEnumerable<Role>> Handle(GetAllRolesQueryRequest request, CancellationToken cancellationToken)
        {
            var roles =  _TeamaContext.Roles.ToListAsync();
            if (roles == null)
            {
                throw new ApplicationException();
            }
            return await roles;
        }
    }
}
