using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public class LogLeo
    {
        private static LogLeo singleton_Practice = null;

        private string FileLeo;

        public static LogLeo GetInstance(string path)
        {
            if (singleton_Practice == null)
            {
                singleton_Practice = new LogLeo(path);

            }
            return singleton_Practice;
        }

        private LogLeo(string path)
        {
            FileLeo = path;
        }

        public void SaveFile(string logInfo)
        {
            File.AppendAllText(FileLeo, string.Concat(logInfo, Environment.NewLine));

        }
    }
}
