using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using Teama.Application.Queries.Roles;
using Teama.Domain.Entities;
using Teama.Infrastructure.Persistence;

namespace Teama.Application.Handlers.Roles
    {
        public class GetRoleByIdQueryHandler : IRequestHandler<GetRoleByIdQueryRequest,Role>
        {

            private readonly TeamaContext _TeamaContext;
            public GetRoleByIdQueryHandler(TeamaContext teamaContext)
            {
                _TeamaContext = teamaContext;

            }
            public async Task<Role > Handle(GetRoleByIdQueryRequest request, CancellationToken cancellationToken)
            {
                var role = _TeamaContext.Roles.FindAsync(request.Id);
                if (role == null)
                {
                    throw new ApplicationException();
                }
                return await role;
            }
        }
    }
