using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class TimeLog : EntityBase
    {
        public long Id { get; set; }
        public int WorkTaskId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Minutes { get; set; }
        public Guid UserId { get; set; }
    }
}
