using System;
using System.Collections.Generic;
using System.Text;
using Teama.Domain.Entities;
using Teama.Infrastructure.Persistence;
using Teama.Infrastructure.Persistence.Base;

namespace Teama.Infrastructure.Repositories
{
public    class ProjectRepository:Repository<Project>
    {
        public ProjectRepository(TeamaContext teamaContext ):base(teamaContext)
        {

        }
    }
}
