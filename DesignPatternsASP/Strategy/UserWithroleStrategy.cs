using DesignPatterns.Repository;
using DesignPatternsASP.Models.ViwModels;
using DesignPatters.Model.Data;

namespace DesignPatternsASP.Strategy
{
    public class UserWithroleStrategy : IUserStrategy
    {
        public void add(UserRoleViewModel UserrolVm, IUnitOfWork unitOfWork)
        {
            var user = new Users();
            var userRolesAsignment = new UserRoleAssignment();
            var roles = new Roles();

            user.UserId = Guid.NewGuid();
            user.UserName = UserrolVm.UserName;
            user.Password = UserrolVm.Password;
            user.UserFullName = UserrolVm.UserFullName;

            roles.RoleId = Guid.NewGuid();
            roles.Description = UserrolVm.OtherRole;

            userRolesAsignment.UserRoleAssignmentId = Guid.NewGuid();
            userRolesAsignment.UserId = user.UserId;
            userRolesAsignment.RolId = roles.RoleId;

            unitOfWork.Users.Add(user);
            unitOfWork.Roles.Add(roles);
            unitOfWork.UserroleAssignment.Add(userRolesAsignment);

            unitOfWork.Save();
        }
    }
}
