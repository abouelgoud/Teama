using System;
using System.Collections.Generic;
using System.Text;
using Teama.Domain.Common;

namespace Teama.Domain.Entities
{
   public class Project:AuditableEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Users { get; set; }
        public string Photo { get; set; }


        public List<Task> Tasks { get; set; }

    }
}
