using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DesignPatternsASP.Models.ViwModels
{
    public class UserRoleViewModel
    {
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string UserFullName { get; set; }

        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string UserName { get; set; }

        [Required]
        [StringLength(30)]
        [Unicode(false)]
        public string Password { get; set; }

        public Guid? RoleId { get; set; }

        [StringLength(30)]
        [Unicode(false)]
        [Display(Name = "New Rol")]
        public string OtherRole { get; set; }
    }
}
