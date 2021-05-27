using System;
using System.Collections.Generic;
using System.Text;

namespace Teama.Domain.Common
{
    public interface IEntityBase<TId>
    {
        TId Id { get; }
    }
}
