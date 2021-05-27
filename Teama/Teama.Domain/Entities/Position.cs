using System;
using System.Collections.Generic;
using System.Text;
using Teama.Domain.Common;

namespace Teama.Domain.Entities
{
    public class Position:AuditableEntity
    {
        public string PositionName { get; set; }

    }
}
