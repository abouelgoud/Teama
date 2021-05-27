using System;
using System.Collections.Generic;
using System.Text;
using Teama.Domain.Enums;

namespace Teama.Domain.Common
{
    public class Status
    {
        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public string ArabicStatusName { get; set; }
        public virtual StatusTypes StatusType { get; set; }


    }
}
