using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 仅使用策略模式的调用方法
            string type = string.Empty;
            double originalMoney = 100;
            double totalPrices;
            CashContext cc = null;
            switch (type) 
            {
                case "正常消费":
                    cc = new CashContext(new CashNormal());
                    break;
                case "满300返100":
                    cc = new CashContext(new CashReturn("300", "100"));
                    break;
                case "打8折":
                    cc = new CashContext(new CashRebate("0.8"));
                    break;
            }

            totalPrices = cc.GetResult(originalMoney);
            Console.WriteLine(type + "合计：" + totalPrices.ToString());
            #endregion

            #region 使用简单工厂改造CashContext后的调用方法
            CashContext_SimpleFactory context_SimpleFactory = new CashContext_SimpleFactory(type);
            totalPrices = context_SimpleFactory.GetResult(originalMoney);
            Console.WriteLine(type + "合计：" + totalPrices.ToString());
            #endregion
        }
    }
}
