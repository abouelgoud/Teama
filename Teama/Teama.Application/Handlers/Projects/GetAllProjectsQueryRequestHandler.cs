using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Teama.Application.Queries.Projects;
using Teama.Domain.Entities;
using Teama.Infrastructure.Persistence;
namespace Teama.Application.Queries.Projects
    {
        public class GetAllProjectsQueryRequestHandler : IRequestHandler<GetAllProjectsQueryRequest,IEnumerable < Project>>
        {
            private readonly TeamaContext  _TeamaContext;
            public GetAllProjectsQueryRequestHandler(TeamaContext teamaContext)
            {
                _TeamaContext = teamaContext;

            }
               public async Task<IEnumerable < Project>> Handle(GetAllProjectsQueryRequest request, CancellationToken cancellationToken)
             {
             var projects = _TeamaContext.Projects.ToListAsync();
             if (projects == null)
             {
                throw new ApplicationException();
             }
              return await projects;
              }
        }
    }
