using System;
using System.Collections.Generic;
using System.Text;
using Teama.Domain.Common;

namespace Teama.Domain.Entities
{
public class Role:AuditableEntity
    {
        public string RoleName { get; set; }


    }
}
