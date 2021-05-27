using System;
using System.Collections.Generic;
using System.Text;
using Teama.Domain.Entities;
using Teama.Infrastructure.Persistence;
using Teama.Infrastructure.Persistence.Base;

namespace Teama.Infrastructure.Repositories
{
public    class RequestTypeRepository:Repository<RequestType>
    {
        public RequestTypeRepository(TeamaContext teamaContext ):base(teamaContext)
        {

        }
    }
}
