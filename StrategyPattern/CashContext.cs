using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class CashContext
    {
        private CashSuper cs;

        public CashContext(CashSuper csuper) 
        {
            this.cs = csuper;
        }

        public double GetResult(double money) 
        {
            return cs.acceptCash(money);
        }
    }

    /// <summary>
    /// 使用简单工厂改造
    /// </summary>
    internal class CashContext_SimpleFactory 
    {
        CashSuper cs = null;

        public CashContext_SimpleFactory(string type) 
        {
            switch (type)
            {
                case "正常消费":
                    CashNormal cs0 = new CashNormal();
                    cs = cs0;
                    break;
                case "满300返100":
                    CashReturn cs1 = new CashReturn("300", "100");
                    cs = cs1;
                    break;
                case "打8折":
                    CashRebate cs2 = new CashRebate("0.8");
                    break;
            }
        }

        public double GetResult(double money) 
        {
            return cs.acceptCash(money);
        }
    }
}
