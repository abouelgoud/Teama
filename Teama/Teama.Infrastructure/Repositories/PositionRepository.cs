using System;
using System.Collections.Generic;
using System.Text;
using Teama.Domain.Entities;
using Teama.Infrastructure.Persistence;
using Teama.Infrastructure.Persistence.Base;

namespace Teama.Infrastructure.Repositories
{
   public class PositionRepository:Repository<Position>
    {
        public PositionRepository(TeamaContext teamaContext):base(teamaContext)
        {

        }
    }
}
