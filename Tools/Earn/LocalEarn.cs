using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.Earn
{
    public class LocalEarn : IEarn
    {
        private decimal _percentage;

        public LocalEarn(decimal percentage)
        {
            _percentage = percentage;
        }

        public decimal Earn(decimal ammount)
        {
            return ammount * _percentage;
        }
    }
}
