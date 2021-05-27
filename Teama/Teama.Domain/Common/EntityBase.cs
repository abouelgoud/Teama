using System;
using System.Collections.Generic;
using System.Text;

namespace Teama.Domain.Common
{
    public abstract class EntityBase<TId> : IEntityBase<TId>
    {
        public virtual TId Id { get; protected set; }


    }
}
