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
	/// Demo4-Unity容器依赖注入
	/// </summary>
	public class Demo4
	{
		public static void Run()
		{
			IUnityContainer container = new UnityContainer();//1 空容器
			container.RegisterType<IPhone, ApplePhone>();//2 注册类型			
			container.RegisterType<IHeadphone, Headphone>();
			container.RegisterType<IMicrophone, Microphone>();
			container.RegisterType<IPower, Power>();
			container.RegisterType<IBLL.IBaseBll, BLL.BaseBll>();
			container.RegisterType<IDAL.IBaseDAL, Ruamou.DAL.BaseDAL>();
			var phone = container.Resolve<IPhone>();

			Console.WriteLine($"phone.iHeadphone==null?  {phone.iHeadphone == null}");
			Console.WriteLine($"phone.iMicrophone==null? {phone.iMicrophone == null}");
			Console.WriteLine($"phone.iPower==null?      {phone.iPower == null}");
			Console.WriteLine($"phone.iBLL==null?      {phone.iBLL == null}");
		
			var _ = 0;
		}
	}
}
