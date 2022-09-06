using DesignPatterns.Repository;
using DesignPatternsASP.Models.ViwModels;
using DesignPatternsASP.Strategy;
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
            GetRoleData();

            return View();
        }

        [HttpPost]
        public IActionResult Add(UserRoleViewModel UserRoleVm)
        {
            if (!ModelState.IsValid)
            {
                GetRoleData();

                return View ("Add", UserRoleVm);
            }

            var context = UserRoleVm.RoleId == null ? new UserContext(new UserWithroleStrategy()):new UserContext(new UserStrategy());

            context.Add(UserRoleVm, _unitOfWork);

            return RedirectToAction("Index");
        }

        #region HELPERS
        private void GetRoleData()
        {
            var Roleselect = _unitOfWork.Roles.Get();
            ViewBag.Roleelect = new SelectList(Roleselect, "RoleId", "Description");
        }
        #endregion
    }
}
