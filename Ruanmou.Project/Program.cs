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
				//Demo1 - 利用反射手动实现IOC
				//Demo.Demo1.Run();
				
				//Demo2-创建对象依赖链依赖于细节展示
				//Demo.Demo2.Run();

				
				//Demo3-Unity容器的初步应用
				//Demo.Demo3.Run();								
				
				// Demo4-Unity容器依赖注入
				Demo.Demo4.Run();



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
