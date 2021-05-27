using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using Teama.Application.Queries.Projects;
using Teama.Domain.Entities;
using Teama.Infrastructure.Persistence;

namespace Teama.Application.Handlers.Projects
    {
        public class GetProjectByIdQueryHandler : IRequestHandler<GetProjectByIdQueryRequest,Project>
        {

            private readonly TeamaContext _TeamaContext;
            public GetProjectByIdQueryHandler(TeamaContext teamaContext)
            {
                _TeamaContext = teamaContext;

            }
            public async Task<Project > Handle(GetProjectByIdQueryRequest request, CancellationToken cancellationToken)
            {
                var project = _TeamaContext.Projects.FindAsync(request.Id);
                if (project == null)
                {
                    throw new ApplicationException();
                }
                return await project;
            }
        }
    }
