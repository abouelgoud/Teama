using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Teama.Domain.Entities;

namespace Teama.Application.Queries.RequestTypes
    {
        public class GetRequestTypeByIdQueryRequest : IRequest<RequestType>
        {
           public int Id { get; set; }
        }
    }
