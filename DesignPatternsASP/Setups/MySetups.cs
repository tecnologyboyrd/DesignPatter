using DesignPatternsASP.Interfaces;
using Microsoft.Extensions.Configuration;
using System.Configuration;

namespace DesignPatternsASP.Setups
{    
    public class MySetups : ImySetup
    {        
        public MySetups()
        {
            var path = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("MySetups")["PathLog"];

            pathLog = path;
        }


        private string pathLog;

        public string PathLog
        {
            get { return pathLog; }
            set { pathLog = value; }
        }




        //public string PathLog { get; set; }

    }
}
