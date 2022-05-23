using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Singleton
{
    public class LPS_Singleton_practice
    {
        private static readonly LPS_Singleton_practice singleton_Practice = new LPS_Singleton_practice();

        private string FileLeo = "FileLeo.txt";

        public static LPS_Singleton_practice Singleton_Practice 
        {
            get 
            {
                return singleton_Practice;
            }
        }

        private LPS_Singleton_practice()
        {
            
        }

        public void SaveFile(string logInfo)
        {
            File.WriteAllText(FileLeo, string.Concat(logInfo, Environment.NewLine));

        }
    }
}
