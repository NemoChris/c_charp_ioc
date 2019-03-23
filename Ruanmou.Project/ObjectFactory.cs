using Ruanmou.IBLL;
using Ruanmou.Interface;
using System;
using System.Configuration;
using System.Reflection;

namespace Ruanmou.Project
{
    /// <summary>
    /// 简单工厂+配置文件+反射
    /// </summary>
    public class ObjectFactory
    {
        public static IPhone CreatePhone()
        {
            string classModule = ConfigurationManager.AppSettings["iPhoneType"];
            Assembly assemly = Assembly.Load(classModule.Split(',')[1]);
            Type type = assemly.GetType(classModule.Split(',')[0]);
            return (IPhone)Activator.CreateInstance(type);//无参数构造函数
        }

        public static IPhone CreatePhone(IBaseBll iBLL)
        {
            string classModule = ConfigurationManager.AppSettings["iPhoneType"];
            Assembly assemly = Assembly.Load(classModule.Split(',')[1]);
            Type type = assemly.GetType(classModule.Split(',')[0]);
            return (IPhone)Activator.CreateInstance(type, new object[] { iBLL });
        }
    }
}
