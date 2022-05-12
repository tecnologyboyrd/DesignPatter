using DesignPatternsASP.Models;
using DesignPatternsASP.Setups;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Diagnostics;
using Tools;

namespace DesignPatternsASP.Controllers
{
    public class HomeController : Controller
    {
        //private readonly IOptions<MySetups> _config;   
        
        public HomeController(IOptions<MySetups> config)
        {
            //_config = config;
        }

        
        public IActionResult Index()
        {
            Log.GetInstance("log.txt").Save("Entro a Home");
            //Log.GetInstance(_config.Value.PathLog).Save("entro a index");
            return View();
        }

        public IActionResult Privacy()
        {
            Log.GetInstance("log.txt").Save("Entro a Privacy");

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}