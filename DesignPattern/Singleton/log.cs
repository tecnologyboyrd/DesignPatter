using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Singleton
{
    public class Log
    {
        public readonly static Log _instance = new Log();

        private string fileLog = "appLog.txt";

        private Log() 
        {

        }
        public static Log Instance 
        {
            get { return _instance; } 
        }

        public void Save( string message)
        {
            File.AppendAllText(fileLog, message + Environment.NewLine);
        }

    }
}
