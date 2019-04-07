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
	/// Demo2-通过配置文件实现Aop
	/// </summary>
	public class Demo2
	{
		public static void Run()
		{
			Console.WriteLine("*****************UnityContainer*********************");
			{
				ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap();
				fileMap.ExeConfigFilename = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "CfgFiles\\Unity.Config");//找配置文件的路径
				Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);
				UnityConfigurationSection section = (UnityConfigurationSection)configuration.GetSection(UnityConfigurationSection.SectionName);

				//只有配置的register节点才会有Aop
				//如果都在执行前或都在执行后，Aop的执行顺序和配置的顺序一直
				//Aop针对对象的所有公用方法
				IUnityContainer container = new UnityContainer();
				section.Configure(container, "testContainerAOP");
				IPhone phone = container.Resolve<IPhone>();
				phone.Call();
				phone.SendMsg();

				IPhone phone1 = container.Resolve<IPhone>("apple");
				phone1.Call();
				phone1.SendMsg();

				IPhone phone2 = container.Resolve<IPhone>("android");
				phone2.Call();
				phone2.SendMsg();
			}

		}
	}
}
