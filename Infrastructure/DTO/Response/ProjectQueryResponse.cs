using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.DTO.Response
{
    public class ProjectQueryResponse
    {
        public long Id { get; set; }
        public long AppId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid Lead { get; set; }
    }
}
