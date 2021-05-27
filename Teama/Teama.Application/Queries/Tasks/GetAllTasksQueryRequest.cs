using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Teama.Domain.Entities;

namespace Teama.Application.Queries.Tasks
    {
        public class GetAllTasksQueryRequest : IRequest<IEnumerable<Task>>
        {
        }
    }
