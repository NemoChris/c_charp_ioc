using Microsoft.Practices.Unity.Configuration;
using Ruanmou.Interface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Interception;
using Unity.Interception.Interceptors.InstanceInterceptors.InterfaceInterception;

namespace Ruanmou.Project.AopDemo
{
	/// <summary>
	/// Demo1-给类添加特性实现AOP
	/// </summary>
	public class Demo1
	{
		public static void Run()
		{
			//AOP 面向切面编程，在执行具体业务的前后做其他的操作
			Console.WriteLine("*****************UnityContainer*********************");
			{
				ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap();
				fileMap.ExeConfigFilename = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "CfgFiles\\Unity.Config");//找配置文件的路径
				Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);
				UnityConfigurationSection section = (UnityConfigurationSection)configuration.GetSection(UnityConfigurationSection.SectionName);

				IUnityContainer container = new UnityContainer();
				section.Configure(container, "testContainer");

				//给Iphone注册aop
				container.AddNewExtension<Interception>().Configure<Interception>()
			   .SetInterceptorFor<IPhone>(new InterfaceInterceptor());

				IPhone phone = container.Resolve<IPhone>();
				phone.Call();

				IPhone android = container.Resolve<IPhone>("Android");
				android.Call();

				var _ = 0;
			}

		}
	}
}
