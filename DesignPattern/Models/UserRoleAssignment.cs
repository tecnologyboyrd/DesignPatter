using System;
using System.Collections.Generic;

namespace DesignPattern.Models
{
    public partial class UserRoleAssignment
    {
        public int AutoSec { get; set; }
        public Guid UserRoleAssignmentId { get; set; }
        public Guid UserId { get; set; }
        public Guid RolId { get; set; }

        public virtual User User { get; set; } = null!;
    }
}
