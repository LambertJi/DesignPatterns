using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    /// <summary>
    /// 社区志愿者工厂
    /// </summary>
    internal class VolunteerFactory : IFactory
    {
        public LeiFeng CreateLeiFeng() 
        {
            return new Volunteer();
        }
    }
}
