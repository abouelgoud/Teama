using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using Teama.Application.Queries.Tasks;
 
using Teama.Infrastructure.Persistence;

namespace Teama.Application.Handlers.Tasks
    {
        public class GetTaskByIdQueryHandler : IRequestHandler<GetTaskByIdQueryRequest, Teama.Domain.Entities.Task>
        {

            private readonly TeamaContext _TeamaContext;
            public GetTaskByIdQueryHandler(TeamaContext teamaContext)
            {
                _TeamaContext = teamaContext;

            }
            public async Task<Teama.Domain.Entities.Task> Handle(GetTaskByIdQueryRequest request, CancellationToken cancellationToken)
            {
                var task = _TeamaContext.Tasks.FindAsync(request.Id);
                if (task == null)
                {
                    throw new ApplicationException();
                }
                return await task;
            }
        }
    }
