using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public abstract class EntityBase
    {
        public long CreatedBy { get; set; }
        public long ModifiedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }

    }
}
