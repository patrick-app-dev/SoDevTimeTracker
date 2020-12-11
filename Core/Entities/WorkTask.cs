using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class WorkTask : EntityBase
    {
        public long Id { get; set; }
        public long ProjectId { get; set; }
        public string WorkDescription { get; set; }
        public Guid AssignedTo { get; set; }

    }
}
