using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Teama.Application.Queries.Tasks;
using Teama.Domain.Entities;
using Teama.Infrastructure.Persistence;
namespace Teama.Application.Queries.Tasks
    {
        public class GetAllTasksQueryRequestHandler : IRequestHandler<GetAllTasksQueryRequest,IEnumerable <Teama.Domain.Entities.Task>>
        {
            private readonly TeamaContext  _TeamaContext;
            public GetAllTasksQueryRequestHandler(TeamaContext teamaContext)
            {
                _TeamaContext = teamaContext;

            }
               public async Task<IEnumerable <Teama.Domain.Entities.Task>> Handle(GetAllTasksQueryRequest request, CancellationToken cancellationToken)
             {
             var tasks = _TeamaContext.Tasks.ToListAsync();
             if (tasks == null)
             {
                throw new ApplicationException();
             }
              return await tasks;
              }
        }
    }
