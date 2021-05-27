using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teama.Application.Queries.Users;
using Teama.Domain.Entities;

namespace Teama.API.Controllers
    {
        [Route("api/[controller]")]
        [ApiController]
        public class UsersController : ControllerBase
        {
            private readonly IMediator _Mediator;
            public UsersController(IMediator mediator)
            {
                _Mediator = mediator;
            }
            [HttpGet()]
            public async Task<IEnumerable<User>> GetAsync()
            {
                var query = new GetAllUsersQueryRequest();
                var result = _Mediator.Send(query);
                return await result;
            }
            [HttpGet("{id}")]
            public async Task<User> GetAsync(int id)
            {
                var query = new GetUserByIdQueryRequest();
                query.Id = id;
                var result = _Mediator.Send(query);
                return await result;
            }
        }
    }
