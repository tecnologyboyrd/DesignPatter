using System;
using System.Collections.Generic;

namespace DesignPattern.Models
{
    public partial class Role
    {
        public int AutoSec { get; set; }
        public Guid RoleId { get; set; }
        public string? Description { get; set; }
    }
}
