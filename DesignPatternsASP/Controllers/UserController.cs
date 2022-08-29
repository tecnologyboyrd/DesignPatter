using DesignPatterns.Repository;
using DesignPatternsASP.Models.ViwModels;
using DesignPatters.Model.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DesignPatternsASP.Controllers
{
    public class UserController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            
        }

        public IActionResult Index()
        {
            IEnumerable<UserViewModel> User = from usr in _unitOfWork.Users.Get()
                                              select new UserViewModel
                                              {
                                                  UserId = usr.UserId,
                                                  UserName = usr.UserName,
                                                  UserFullName = usr.UserFullName
                                              };

            return View("Index", User);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var Role = _unitOfWork.Roles.Get();

            ViewBag.Roleelect = new SelectList(Role, "RoleId", "Description");

            return View();
        }

        [HttpPost]
        public IActionResult Add(UserRoleViewModel UserRoleVm)
        {

            var Roleselect = _unitOfWork.Roles.Get();

            if (!ModelState.IsValid)
            {
                ViewBag.Roleelect = new SelectList(Roleselect, "RoleId", "Description");
            }

            var User = new Users();

            var UrA = new UserRoleAssignment();

            var Role = new Roles();

            User.UserId = Guid.NewGuid();
            User.UserFullName = UserRoleVm.UserFullName;
            User.UserName = UserRoleVm.UserName;
            User.Password = UserRoleVm.Password;
            UrA.UserId = User.UserId;

            _unitOfWork.Users.Add(User);


            if (UserRoleVm.RoleId == null)
            {
                Role.RoleId = Guid.NewGuid();
                Role.Description = UserRoleVm.OtherRole;
                UrA.RolId = Role.RoleId;

                _unitOfWork.Roles.Add(Role);
            }
            else
            {
                Role.RoleId = (Guid)UserRoleVm.RoleId;
                UrA.RolId = Role.RoleId;
            }            

            
            UrA.UserRoleAssignmentId = Guid.NewGuid();

            _unitOfWork.UserroleAssignment.Add(UrA);

            _unitOfWork.Save();

            return RedirectToAction("Index");
        }


    }
}
