using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using Teama.Application.Queries.RequestTypes;
using Teama.Domain.Entities;
using Teama.Infrastructure.Persistence;

namespace Teama.Application.Handlers.RequestTypes
    {
        public class GetRequestTypeByIdQueryHandler : IRequestHandler<GetRequestTypeByIdQueryRequest,RequestType>
        {

            private readonly TeamaContext _TeamaContext;
            public GetRequestTypeByIdQueryHandler(TeamaContext teamaContext)
            {
                _TeamaContext = teamaContext;

            }
            public async Task<RequestType > Handle(GetRequestTypeByIdQueryRequest request, CancellationToken cancellationToken)
            {
                var requestType = _TeamaContext.RequestTypes.FindAsync(request.Id);
                if (requestType == null)
                {
                    throw new ApplicationException();
                }
                return await requestType;
            }
        }
    }
