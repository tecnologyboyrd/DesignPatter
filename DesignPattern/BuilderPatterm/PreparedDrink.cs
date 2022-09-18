using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BuilderPatterm
{
    public class PreparedDrink
    {
        public List<string> Ingredients = new List<string>();
        public int Milks;
        public int Water;
        public decimal alcohol;

        public string result;
    }
}
