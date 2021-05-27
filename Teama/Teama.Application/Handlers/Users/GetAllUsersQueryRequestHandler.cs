using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Teama.Application.Queries.Users;
using Teama.Domain.Entities;
using Teama.Infrastructure.Persistence;
namespace Teama.Application.Queries.Users
    {
        public class GetAllUsersQueryRequestHandler : IRequestHandler<GetAllUsersQueryRequest,IEnumerable < User>>
        {
            private readonly TeamaContext  _TeamaContext;
            public GetAllUsersQueryRequestHandler(TeamaContext teamaContext)
            {
                _TeamaContext = teamaContext;

            }
               public async Task<IEnumerable < User>> Handle(GetAllUsersQueryRequest request, CancellationToken cancellationToken)
             {
             var users = _TeamaContext.Users.ToListAsync();
             if (users == null)
             {
                throw new ApplicationException();
             }
              return await users;
              }
        }
    }
