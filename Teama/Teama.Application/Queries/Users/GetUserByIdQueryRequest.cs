using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Teama.Domain.Entities;

namespace Teama.Application.Queries.Users
    {
        public class GetUserByIdQueryRequest : IRequest<User>
        {
           public int Id { get; set; }
        }
    }
