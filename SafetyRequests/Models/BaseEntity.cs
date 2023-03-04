using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SafetyRequests.Models
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public long newId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}
