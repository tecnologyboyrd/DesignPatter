using System;
using System.Collections.Generic;

namespace DesignPattern.Models
{
    public partial class User
    {
        public User()
        {
            UserRoleAssignments = new HashSet<UserRoleAssignment>();
        }

        public int AutoSeq { get; set; }
        public Guid UserId { get; set; }
        public string? UserFullName { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }

        public virtual ICollection<UserRoleAssignment> UserRoleAssignments { get; set; }
    }
}
