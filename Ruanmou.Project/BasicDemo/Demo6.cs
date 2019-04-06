using Ruanmou.Interface;
using Ruanmou.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Unity;
using Unity.Lifetime;

namespace Ruanmou.Project.Demo
{
	/// <summary>
	/// Demo6-Unity生命周期
	/// </summary>
	public class Demo6
	{
		public static void Run()
		{
			//除了默认的瞬时生命周期，其他的使用较少都是在特定的场景下使用的
			//生命周期
			IUnityContainer container = new UnityContainer();
			//container.RegisterType<IPhone, AndroidPhone>();
			//container.RegisterType<IPhone, AndroidPhone>(new TransientLifetimeManager());//默认  瞬时  每一次都是全新生成
			//container.RegisterType<IPhone, AndroidPhone>(new ContainerControlledLifetimeManager());//容器单例 即指定容器声明的对象都是同一对象 单例就不要自己实现
			//container.RegisterType<IPhone, AndroidPhone>(new PerThreadLifetimeManager());//线程单例 即一个线程内声明的对象为同一对象
			var phone1 = container.Resolve<IPhone>();
			var phone2 = container.Resolve<IPhone>();
			Console.WriteLine(object.ReferenceEquals(phone1, phone2));

			//container.RegisterType<IPhone, AndroidPhone>(new HierarchicalLifetimeManager());//分级容器单例 即容器可分列为子容器，每个自容器创建的都是容器内的单例
			//IUnityContainer childContainer = container.CreateChildContainer();

			//container.RegisterType<IPhone, AndroidPhone>(new ExternallyControlledLifetimeManager());//外部可释放单例 即当单例被其他使用者释放后，再次使用容器会帮我们创建一个单例
			//container.RegisterType<IPhone, AndroidPhone>(new PerResolveLifetimeManager());//循环引用 不推荐
			IPhone iphone1 = null;
			Action act1 = new Action(() =>
			{
				iphone1 = container.Resolve<IPhone>();
				Console.WriteLine($"iphone1由线程id={Thread.CurrentThread.ManagedThreadId}");
			});
			var result1 = act1.BeginInvoke(null, null);

			IPhone iphone2 = null;
			Action act2 = new Action(() =>
			{
				iphone2 = container.Resolve<IPhone>();
				Console.WriteLine($"iphone2由线程id={Thread.CurrentThread.ManagedThreadId}");
			});

			IPhone iphone3 = null;
			var result2 = act2.BeginInvoke(t =>
			{
				iphone3 = container.Resolve<IPhone>();
				Console.WriteLine($"iphone3由线程id={Thread.CurrentThread.ManagedThreadId}");
				Console.WriteLine($"object.ReferenceEquals(iphone2, iphone3)={object.ReferenceEquals(iphone2, iphone3)}");
			}, null);

			act1.EndInvoke(result1);
			act2.EndInvoke(result2);

			Console.WriteLine($"object.ReferenceEquals(iphone1, iphone2)={object.ReferenceEquals(iphone1, iphone2)}");

			var _ = 0;
		}
	}
}
