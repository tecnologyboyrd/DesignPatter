using Microsoft.AspNetCore.Mvc;
using Tools.Earn;

namespace DesignPatternsASP.Controllers
{
    public class ProducDetailController : Controller
    {
        private EarnFactory _localEarnFactory;
        private EarnFactory _foreignEarnFactory;

        public ProducDetailController(LocalEarnFactory localEarnFactory, ForeignEarnFactory foreignEarnFactory)
        {
            _localEarnFactory = localEarnFactory;
            _foreignEarnFactory = foreignEarnFactory;
        }

        public IActionResult Index(decimal total)
        {
            
            //products
            var LocalEarn = _localEarnFactory.GetEarn();
            var ForeignEarn = _foreignEarnFactory.GetEarn();

            ViewBag.totallocal = total + LocalEarn.Earn(total);
            ViewBag.totalForeign = total + ForeignEarn.Earn(total);

            return View();
        }
    }
}
