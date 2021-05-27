using System;
using System.Collections.Generic;
using System.Text;
using Teama.Domain.Common;
using Teama.Domain.Enums;

namespace Teama.Domain.Entities
{
   public class User:AuditableEntity
    {

        public int UserCode { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public string Email { get; set; }
 


    }
}
