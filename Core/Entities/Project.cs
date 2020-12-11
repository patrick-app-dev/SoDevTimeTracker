using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class Project : EntityBase
    {
        public long Id { get; set; }
        public long AppId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid Lead { get; set; }

    }
}
