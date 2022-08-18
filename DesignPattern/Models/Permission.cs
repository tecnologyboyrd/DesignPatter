using System;
using System.Collections.Generic;

namespace DesignPattern.Models
{
    public partial class Permission
    {
        public int AutoSec { get; set; }
        public Guid PermissionId { get; set; }
        public string Desciption { get; set; } = null!;
    }
}
