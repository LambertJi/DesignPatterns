using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class CashNormal : CashSuper
    {
        public override double acceptCash(double money)
        {
            return money;
        }
    }
}
