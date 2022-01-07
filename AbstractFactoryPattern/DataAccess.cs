using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Configuration;

namespace AbstractFactoryPattern
{
    /// <summary>
    /// 使用反射+配置文件达到最优
    /// </summary>
    internal class DataAccess
    {
        private static readonly string AssemblyName = "AbstractFactoryPattern";
        private static readonly string db = ConfigurationManager.AppSettings["DB"];

        public static IUser CreateUser()
        {
            string className = AssemblyName + "." + db + "User";
            return (IUser)Assembly.Load(AssemblyName).CreateInstance(className);
        }

        public static IDepartment CreateDepartment()
        {
            string className = AssemblyName + "." + db + "Department";
            return (IDepartment)Assembly.Load(AssemblyName).CreateInstance(className);
        }
    }

    /// <summary>
    /// 使用简单工厂来改进
    /// </summary>
    internal class DataAccess_SimpleFactory
    {
        private static readonly string db = "Sqlserver";
        //private static readonly string db = "Access";

        public static IUser CreateUser()
        {
            IUser result;
            switch (db)
            {
                case "Sqlserver":
                    result = new SqlserverUser();
                    break;
                case "Access":
                    result = new AccessUser();
                    break;
                default:
                    result = null;
                    break;
            }
            return result;
        }

        public static IDepartment CreateDepartment()
        {
            IDepartment result;
            switch (db)
            {
                case "Sqlserver":
                    result = new SqlserverDepartment();
                    break;
                case "Access":
                    result = new AccessDepartment();
                    break;
                default:
                    result = null;
                    break;
            }
            return result;
        }
    }
}
