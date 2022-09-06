using DesignPatterns.Repository;
using DesignPatternsASP.Models.ViwModels;
using DesignPatters.Model.Data;

namespace DesignPatternsASP.Strategy
{
    public class UserStrategy : IUserStrategy
    {
        public void add(UserRoleViewModel UserRolVm, IUnitOfWork unitOfWork)
        {
            var user = new Users();
            var userRolesAsignment = new UserRoleAssignment();

            user.UserId = Guid.NewGuid();
            user.UserName = UserRolVm.UserName;
            user.Password = UserRolVm.Password; 
            user.UserFullName = UserRolVm.UserFullName;
            
            userRolesAsignment.UserRoleAssignmentId = Guid.NewGuid();
            userRolesAsignment.UserId = user.UserId;
            userRolesAsignment.RolId = (Guid)UserRolVm.RoleId;

            unitOfWork.Users.Add(user);
            unitOfWork.UserroleAssignment.Add(userRolesAsignment);

            unitOfWork.Save();
        }
    }
}
