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
	/// Demo5-Unity容器使用别名注册多个对象
	/// </summary>
	public class Demo5
	{
		public static void Run()
		{
			IUnityContainer container = new UnityContainer();
			container.RegisterType<IPhone, AndroidPhone>();
			container.RegisterType<IPhone, ApplePhone>();//后注册会替换先前注册的
			container.RegisterType<IPhone, ApplePhone>("Apple");//为apple类型起别名
			container.RegisterType<IPhone, AndroidPhone>("Android");//为android类型起别名
			container.RegisterType<IMicrophone, Microphone>();
			container.RegisterType<IHeadphone, Headphone>();
			container.RegisterType<IPower, Power>();
			container.RegisterType<IBLL.IBaseBll, BLL.BaseBll>();
			container.RegisterType<IDAL.IBaseDAL, Ruamou.DAL.BaseDAL>();

			IPhone iphone1 = container.Resolve<IPhone>();
			iphone1.Call();
			IPhone iphone2 = container.Resolve<IPhone>("Apple");//使用aple别名注册时的类型，即ApplePhone类型
			IPhone iphone3 = container.Resolve<IPhone>("Android");//使用android别名注册时的类型，即AndroidPhone类型
			IPhone iphone4 = container.Resolve<IPhone>();
			IPhone iphone5 = container.Resolve<IPhone>();

			var _ = 0;
		}
	}
}
