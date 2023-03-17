using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.AuditableEntity
{
    public interface IAuditableEntity
    {
        int? ModifiedByUserId { get; set; }
    }
}
