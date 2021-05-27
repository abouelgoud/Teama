using System;
using System.Collections.Generic;
using System.Text;
using Teama.Domain.Entities;
using Teama.Domain.Repositories.Base;
using Teama.Infrastructure.Persistence;
using Teama.Infrastructure.Persistence.Base;

namespace Teama.Infrastructure.Repositories
{
  public  class TaskRepository:Repository<Task>
    {
        public TaskRepository(TeamaContext teamaContext):base(teamaContext)
        {

        }
    }
}
