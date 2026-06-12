using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Domain.Common
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedDate { get; set; }
        public bool isDeleted { get; set; }
    }
}
