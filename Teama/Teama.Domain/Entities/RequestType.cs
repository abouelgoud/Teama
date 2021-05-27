using System;
using System.Collections.Generic;
using System.Text;
using Teama.Domain.Common;

namespace Teama.Domain.Entities
{
    public class RequestType:AuditableEntity
    {
        public string RequestTypeName { get; set; }


        public List<Task> Tasks { get; set; }

    }
}
