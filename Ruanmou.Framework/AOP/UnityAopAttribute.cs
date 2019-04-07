using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Unity;
using Unity.Interception;
using Unity.Interception.ContainerIntegration;
using Unity.Interception.Interceptors.InstanceInterceptors.InterfaceInterception;
using Unity.Interception.PolicyInjection.Pipeline;
using Unity.Interception.PolicyInjection.Policies;//InterceptionExtension

namespace Ruanmou.Framework.AOP
{
	#region 特性对应的行为
	public class UserHandler : ICallHandler
	{
		public int Order { get; set; }
		public IMethodReturn Invoke(IMethodInvocation input, GetNextHandlerDelegate getNext)
		{
			Console.WriteLine("参数检测无误,Order=" + Order);
			IMethodReturn methodReturn = getNext()(input, getNext); //getNext.Invoke().Invoke(input, getNext);
			return methodReturn;
		}
	}

	public class LogHandler : ICallHandler
	{
		public int Order { get; set; }
		/// <summary>
		/// 
		/// </summary>
		/// <param name="input">方法调用的参数列表</param>
		/// <param name="getNext"></param>
		/// <returns></returns>
		public IMethodReturn Invoke(IMethodInvocation input, GetNextHandlerDelegate getNext)
		{						
			Console.WriteLine("日志已记录");
			return getNext()(input, getNext);
		}
	}


	public class ExceptionHandler : ICallHandler
	{
		public int Order { get; set; }
		public IMethodReturn Invoke(IMethodInvocation input, GetNextHandlerDelegate getNext)
		{
			IMethodReturn methodReturn = getNext()(input, getNext);
			if (methodReturn.Exception == null)
			{
				Console.WriteLine("无异常");
			}
			else
			{
				Console.WriteLine($"异常:{methodReturn.Exception.Message}");
			}
			return methodReturn;
		}
	}

	public class AfterLogHandler : ICallHandler
	{
		public int Order { get; set; }
		public IMethodReturn Invoke(IMethodInvocation input, GetNextHandlerDelegate getNext)
		{
			IMethodReturn methodReturn = getNext()(input, getNext);
			Console.WriteLine("AfterLogHandler => methodReturn.ReturnValue={0}", methodReturn.ReturnValue);
			return methodReturn;
		}
	}
	#endregion 特性对应的行为

	#region 特性
	public class UserHandlerAttribute : HandlerAttribute
	{
		public override ICallHandler CreateHandler(IUnityContainer container)
		{
			ICallHandler handler = new UserHandler() { Order = this.Order };
			return handler;
		}
	}

	public class LogHandlerAttribute : HandlerAttribute
	{
		public override ICallHandler CreateHandler(IUnityContainer container)
		{
			return new LogHandler() { Order = this.Order };
		}
	}

	public class ExceptionHandlerAttribute : HandlerAttribute
	{
		public override ICallHandler CreateHandler(IUnityContainer container)
		{
			return new ExceptionHandler() { Order = this.Order };
		}
	}

	public class AfterLogHandlerAttribute : HandlerAttribute
	{
		public override ICallHandler CreateHandler(IUnityContainer container)
		{
			return new AfterLogHandler() { Order = this.Order };
		}
	}
	#endregion 特性

}

