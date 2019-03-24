using Ruanmou.Interface;
using Ruanmou.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace Ruanmou.Project.Demo
{
	/// <summary>
	/// Demo3-Unity容器的初步应用
	/// </summary>
	public class Demo3
	{
		public static void Run()
		{
			//1、实例化容器
			IUnityContainer container = new UnityContainer();
			//2、注册类型
			container.RegisterType<IPhone, AndroidPhone>();
			//3、获取实例
			IPhone phone = container.Resolve<IPhone>();
			container.RegisterType<AbstractPad, ApplePad>();
			var pad = container.Resolve<AbstractPad>();			
			
			Console.WriteLine($"phone.iHeadphone==null?  {phone.iHeadphone == null}");
			Console.WriteLine($"phone.iMicrophone==null? {phone.iMicrophone == null}");
			Console.WriteLine($"phone.iPower==null?      {phone.iPower == null}");
			var _ = 0;
		}
	}
}
