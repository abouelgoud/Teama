using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teama.Application.Queries.Roles;
using Teama.Domain.Entities;

namespace Teama.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly IMediator _Mediator;
        public RolesController(IMediator mediator)
        {
            _Mediator = mediator;
        }
        [HttpGet()]
        public async Task<IEnumerable<Role>> GetAsync()
        {
            var query = new GetAllRolesQueryRequest();
          var result =   _Mediator.Send(query);
            return await result;
        }
        [HttpGet("{id}")]
        public async Task<Role> GetAsync(int id)
        {
            var query = new GetRoleByIdQueryRequest();
            query.Id = id;
            var result = _Mediator.Send(query);
            return await result;
        }
    }
}
