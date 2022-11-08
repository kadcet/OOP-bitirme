using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cdr.Domain.Core
{
    public class AuditEntity : BaseEntity,IAuditEntity
    {
        public DateTime CreatedDate { get; set; }= DateTime.Now;

        public DateTime? UpdatedDate { get; set; }
    }
}
