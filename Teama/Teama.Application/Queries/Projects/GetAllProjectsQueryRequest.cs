using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Teama.Domain.Entities;

namespace Teama.Application.Queries.Projects
    {
        public class GetAllProjectsQueryRequest : IRequest<IEnumerable<Project>>
        {
        }
    }
