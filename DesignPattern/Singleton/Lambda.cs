using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Singleton
{
    public class Lambda
    {
        static Func<int, int> fnFirt= (number) => number * 2;

        static Func<int, int, int> fnSecond = (n1, n2) =>
        {
            int result = 0;
            if (n2 != 0)
            {
                result = n1 / n2;
            }
            else
            {
                result = 0;
            }

            return result;

        };

        public static int Duplied(int number)
        {
            return fnFirt(number);
        }

        public static int Divide(int number1, int number2)
        {
            return fnSecond(number1, number2);
        }

        

        
    }
}
