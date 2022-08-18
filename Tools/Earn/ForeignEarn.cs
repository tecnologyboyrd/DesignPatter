using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.Earn
{
    public class ForeignEarn: IEarn
    {
        private decimal _percentage;
        private decimal _extra;

        public ForeignEarn(decimal percentage, decimal extra)
        {
            _percentage = percentage;
            _extra = extra;
        }

        public decimal Earn(decimal ammount)
        {
            return ammount * _percentage +_extra;
        }
    }
}
