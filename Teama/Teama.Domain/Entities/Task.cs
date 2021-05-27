using System;
using System.Collections.Generic;
using System.Text;
using Teama.Domain.Common;
using Teama.Domain.Enums;

namespace Teama.Domain.Entities
{
   public class Task : AuditableEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Priority Priority { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DueDate { get; set; }
        // public int TicketId { get; set; }

        public int Percentage { get; set; }
        

        public int ProjectId { get; set; }
        public Project Project { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int RequestTypeId { get; set; }
        public RequestType RequestType { get; set; }




    }
}
