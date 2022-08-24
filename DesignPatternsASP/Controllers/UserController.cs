using DesignPatterns.Repository;
using DesignPatternsASP.Models.ViwModels;
using Microsoft.AspNetCore.Mvc;

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
    }
}
