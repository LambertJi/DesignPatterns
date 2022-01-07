using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 使用反射+配置文件达到最优
            User userA = new User();
            Department departmentA = new Department();

            IUser iuA = DataAccess.CreateUser();
            iuA.Insert(userA);
            iuA.GetUser(1);

            IDepartment ideptA = DataAccess.CreateDepartment();
            ideptA.Insert(departmentA);
            ideptA.GetDepartment(1);

            Console.ReadLine();
            #endregion

            #region 使用简单工厂来改进
            User userB = new User();
            Department departmentB = new Department();

            IUser iuB = DataAccess_SimpleFactory.CreateUser();
            iuB.Insert(userB);
            iuB.GetUser(1);

            IDepartment ideptB = DataAccess_SimpleFactory.CreateDepartment();
            ideptB.Insert(departmentB);
            ideptB.GetDepartment(1);

            Console.ReadLine();
            #endregion

            #region 抽象工厂
            User userC = new User();
            Department departmentC = new Department();

            IFactory factory = new SqlserverFactory();
            //IFactory factory = new AccessFactory();

            IUser iuC = factory.CreateUser();
            iuC.Insert(user);
            iuC.GetUser(1);

            IDepartment ideptC = factory.CreateDepartment();
            ideptC.Insert(departmentC);
            ideptC.GetDepartment(1);

            Console.ReadLine();
            #endregion
        }
    }
}
