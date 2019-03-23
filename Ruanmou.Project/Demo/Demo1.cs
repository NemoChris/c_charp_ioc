using Ruanmou.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruanmou.Project.Demo
{
	/// <summary>
	/// Demo1-利用反射手动实现IOC
	/// </summary>
	public class Demo1
	{
		public static void Run()
		{
			//概念
			//IOC 是控制反转，即将创建对象的工作交给容器，是目标
			//DI 是依赖注入，是我们实现控制反转的手段

			//只有抽象，没有细节，好处是扩展
			IPhone phone = ObjectFactory.CreatePhone();
		}
	}
}
