using DesignPatternsASP.Models;
using DesignPatternsASP.Setups;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Diagnostics;
using Tools;
using DesignPatternsASP.Interfaces;

namespace DesignPatternsASP.Controllers
{
    public class HomeController : Controller
    {

        private readonly ImySetup _config;

        private readonly MySetups _configFromAppSetting;

        //private readonly LogLeo _logLeo = LogLeo.GetInstance("tomatulog.txt");


        public HomeController(ImySetup  cnf, IOptions<MySetups> configFromAppSettings)
        {
            _config = cnf;

            _configFromAppSetting = configFromAppSettings.Value;
        }


        public IActionResult Index()
        {
            //ViewBag.line = ViewBag.linea + 1;


            //_logLeo.SaveFile(Convert.ToString(ViewBag.linea) + " - " + "esta es una instania de afianzamiento del conocimiento con todo");
            
            Log.GetInstance(_config.PathLog).Save("Inyeccion a partir de una Interface Pu - Index");

            Log.GetInstance(_configFromAppSetting.PathLog2).Save("Inyeccion a partir de la configuración leo - Index");
            return View();
        }

        public IActionResult Privacy()
        {
            Log.GetInstance(_config.PathLog).Save("Inyeccion a partir de una Interface Pu - Privacy");

            Log.GetInstance(_configFromAppSetting.PathLog2).Save("Inyeccion a partir de la configuración leo - Privacy");

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}