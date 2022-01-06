﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    /// <summary>
    /// 雷锋
    /// </summary>
    internal class LeiFeng
    {
        public void Sweep() 
        {
            Console.WriteLine("扫地");
        }

        public void Wash() 
        {
            Console.WriteLine("洗衣");
        }

        public void BuyRice() 
        {
            Console.WriteLine("买米");
        }
    }
}
