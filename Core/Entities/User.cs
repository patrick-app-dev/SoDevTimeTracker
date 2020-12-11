using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class User : EntityBase
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }

    }
}
