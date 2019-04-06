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

namespace Ruanmou.Project.ConfigDemo
{
	/// <summary>
	/// Demo2-通过修改配置文件修改下端的实现而不影响上端
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

				IUnityContainer container = new UnityContainer();
				section.Configure(container, "testContainerExtend");

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
