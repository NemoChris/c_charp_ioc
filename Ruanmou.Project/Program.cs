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
				//ConfigDemo.Demo1.Run();

				//Demo2 - 通过修改配置文件修改下端的实现而不影响上端
				//上端只依赖于抽象而不依赖于具体的细节
				//上端和下端都依赖于容器
				//容器依赖于配置文件
				//通过修改配置文件即可实现上端和下端无缝的切换
				//ConfigDemo.Demo2.Run();

				#endregion

				#region Unity Aop的实现 

				//BUG:进不去Aop的方法，目前没找到问题
				//Demo1 - 给类添加特性实现AOP
				//AopDemo.Demo1.Run();

				//Demo2 - 通过配置文件实现Aop
				AopDemo.Demo2.Run();

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
