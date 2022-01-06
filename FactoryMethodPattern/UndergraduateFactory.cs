using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    /// <summary>
    /// 学雷锋的大学生工厂
    /// </summary>
    internal class UndergraduateFactory : IFactory
    {
        public LeiFeng CreateLeiFeng()
        {
            return new Undergraduate();
        }
    }
}
