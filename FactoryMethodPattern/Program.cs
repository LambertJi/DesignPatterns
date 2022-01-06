using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFactory factory = new UndergraduateFactory();
            LeiFeng studentA = factory.CreateLeiFeng();
            LeiFeng studentB = factory.CreateLeiFeng();
            LeiFeng studentC = factory.CreateLeiFeng();

            studentA.BuyRice();
            studentB.Sweep();
            studentC.Wash();
        }
    }
}
