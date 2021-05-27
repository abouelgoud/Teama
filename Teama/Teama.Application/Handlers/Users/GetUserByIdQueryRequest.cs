using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using Teama.Application.Queries.Users;
using Teama.Domain.Entities;
using Teama.Infrastructure.Persistence;

namespace Teama.Application.Handlers.Users
    {
        public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQueryRequest,User>
        {

            private readonly TeamaContext _TeamaContext;
            public GetUserByIdQueryHandler(TeamaContext teamaContext)
            {
                _TeamaContext = teamaContext;

            }
            public async Task<User > Handle(GetUserByIdQueryRequest request, CancellationToken cancellationToken)
            {
                var user = _TeamaContext.Users.FindAsync(request.Id);
                if (user == null)
                {
                    throw new ApplicationException();
                }
                return await user;
            }
        }
    }
