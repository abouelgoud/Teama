using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teama.Application.Queries.Projects;
 
using Teama.Domain.Entities;

namespace Teama.API.Controllers
    {
        [Route("api/[controller]")]
        [ApiController]
        public class ProjectsController : ControllerBase
        {
            private readonly IMediator _Mediator;
            public ProjectsController(IMediator mediator)
            {
                _Mediator = mediator;
            }
            [HttpGet()]
            public async Task<IEnumerable<Project>> GetAsync()
            {
                var query = new GetAllProjectsQueryRequest();
                var result = _Mediator.Send(query);
                return await result;
            }
            [HttpGet("{id}")]
            public async Task<Project> GetAsync(int id)
            {
                var query = new GetProjectByIdQueryRequest();
                query.Id = id;
                var result = _Mediator.Send(query);
                return await result;
            }
        }
    }
