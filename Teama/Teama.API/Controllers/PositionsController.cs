using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teama.Application.Queries.Positions;
using Teama.Domain.Entities;

namespace Teama.API.Controllers
    {
        [Route("api/[controller]")]
        [ApiController]
        public class PositionsController : ControllerBase
        {
            private readonly IMediator _Mediator;
            public PositionsController(IMediator mediator)
            {
                _Mediator = mediator;
            }
            [HttpGet()]
            public async Task<IEnumerable<Position>> GetAsync()
            {
                var query = new GetAllPositionsQueryRequest();
                var result = _Mediator.Send(query);
                return await result;
            }
            [HttpGet("{id}")]
            public async Task<Position> GetAsync(int id)
            {
                var query = new GetPositionByIdQueryRequest();
                query.Id = id;
                var result = _Mediator.Send(query);
                return await result;
            }
        }
    }
