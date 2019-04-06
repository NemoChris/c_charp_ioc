using Ruanmou.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruanmou.Project.Demo
{
	/// <summary>
	/// Demo2-构造对象依赖链，Demo1简单容器仍然无法解决依赖于细节需要手动指定创建对象
	/// </summary>
	public class Demo2
	{
		public static void Run()
		{
			//概念
			//IOC 是控制反转，即将创建对象的工作交给容器，是目标
			//DI 是依赖注入，是我们实现控制反转的手段

			//A依赖B，B依赖C
			//因此先构造C再构造B再构造A，程序依赖于细节，可扩展性差
			IDAL.IBaseDAL baseDAL = new Ruamou.DAL.BaseDAL();
			IBLL.IBaseBll baseBLL = new Ruanmou.BLL.BaseBll(baseDAL, 1);
			IPhone phone = ObjectFactory.CreatePhone(baseBLL);			
		}
	}
}
