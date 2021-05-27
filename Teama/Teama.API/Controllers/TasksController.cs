using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teama.Application.Queries.Tasks;
using Teama.Domain.Entities;

namespace Teama.API.Controllers
    {
        [Route("api/[controller]")]
        [ApiController]
        public class TasksController : ControllerBase
        {
            private readonly IMediator _Mediator;
            public TasksController(IMediator mediator)
            {
                _Mediator = mediator;
            }
            [HttpGet()]
            public async Task<IEnumerable<Teama.Domain.Entities.Task>> GetAsync()
            {
                var query = new GetAllTasksQueryRequest();
                var result = _Mediator.Send(query);
                return await result;
            }
            [HttpGet("{id}")]
            public async Task<Teama.Domain.Entities.Task> GetAsync(int id)
            {
                var query = new GetTaskByIdQueryRequest();
                query.Id = id;
                var result = _Mediator.Send(query);
                return await result;
            }
        }
    }
