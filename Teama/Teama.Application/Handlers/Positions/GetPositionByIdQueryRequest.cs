using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using Teama.Application.Queries.Positions;
using Teama.Domain.Entities;
using Teama.Infrastructure.Persistence;

namespace Teama.Application.Handlers.Positions
    {
        public class GetPositionByIdQueryHandler : IRequestHandler<GetPositionByIdQueryRequest,Position>
        {

            private readonly TeamaContext _TeamaContext;
            public GetPositionByIdQueryHandler(TeamaContext teamaContext)
            {
                _TeamaContext = teamaContext;

            }
            public async Task<Position > Handle(GetPositionByIdQueryRequest request, CancellationToken cancellationToken)
            {
                var position = _TeamaContext.Positions.FindAsync(request.Id);
                if (position == null)
                {
                    throw new ApplicationException();
                }
                return await position;
            }
        }
    }
