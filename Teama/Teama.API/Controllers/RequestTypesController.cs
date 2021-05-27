using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teama.Application.Queries.RequestTypes;
using Teama.Domain.Entities;

namespace Teama.API.Controllers
    {
        [Route("api/[controller]")]
        [ApiController]
        public class RequestTypesController : ControllerBase
        {
            private readonly IMediator _Mediator;
            public RequestTypesController(IMediator mediator)
            {
                _Mediator = mediator;
            }
            [HttpGet()]
            public async Task<IEnumerable<RequestType>> GetAsync()
            {
                var query = new GetAllRequestTypesQueryRequest();
                var result = _Mediator.Send(query);
                return await result;
            }
            [HttpGet("{id}")]
            public async Task<RequestType> GetAsync(int id)
            {
                var query = new GetRequestTypeByIdQueryRequest();
                query.Id = id;
                var result = _Mediator.Send(query);
                return await result;
            }
        }
    }
