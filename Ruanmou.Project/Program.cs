using Microsoft.Practices.Unity.Configuration;
using Ruamou.DAL;
using Ruanmou.Framework.DIOC;
using Ruanmou.IDAL;
using Ruanmou.Interface;
using Ruanmou.Service;
//using Ruanmou.Service;
//using Ruanmou.Service;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Unity;
using Unity.Interception;
using Unity.Interception.Interceptors.InstanceInterceptors.InterfaceInterception;
using Unity.Lifetime;

namespace Ruanmou.Project
{

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
				#region Unity容器的基本应用
				//Demo1 - 利用反射手动实现IOC
				//Demo.Demo1.Run();

				//Demo2-创建对象依赖链依赖于细节展示
				//Demo.Demo2.Run();


				//Demo3-Unity容器的初步应用
				//Demo.Demo3.Run();								

				// Demo4-Unity容器依赖注入
				//Demo.Demo4.Run();

				// Demo5-Unity别名实现多个对象注册注入
				//Demo.Demo5.Run();

				//Demo6-Unity生命周期
				//Demo.Demo6.Run(); 
				#endregion

				#region Unity容器的配置
				//Demo1 - 通过配置文件创建对象
				ConfigDemo.Demo1.Run();
				#endregion

			}
			catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
				if (ex.InnerException!=null)
				{
					Console.WriteLine(ex.InnerException.Message);
				}				
			}
            Console.Read();
        }
    }
}
