using System;
using System.Collections.Generic;
using System.Text;

namespace Teama.Domain.Common
{
    public abstract class AuditableEntity : EntityBase<int>
    {
        public DateTime? Created { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? LastModified { get; set; }
        public int? LastModifiedBy { get; set; }
        public int StatusId { get; set; }
        public virtual Status Status { get; set; }
        public string Remarks { get; set; }
        public string ArabicRemarks { get; set; }
    }


    public interface IAuditableEntity<TId>
    {
        TId Id { get; }
    }
}
