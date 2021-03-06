﻿using Ruanmou.Framework.AOP;
using Ruanmou.IBLL;
using Ruanmou.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace Ruanmou.Service
{
	public class ApplePhone : IPhone
    {
        [Dependency]//属性注入
        public IMicrophone iMicrophone { get; set; }
        public IHeadphone iHeadphone { get; set; }
        public IPower iPower { get; set; }
		[Dependency]//属性注入
		public IBaseBll iBLL { get; set; }

		public ApplePhone()
        {
            Console.WriteLine("{0}构造函数", this.GetType().Name);
        }

		//public ApplePhone(IBaseBll baseBll)
		//{
		//	this.iBLL = baseBll;
		//	Console.WriteLine("{0}构造函数", this.GetType().Name);
		//}


		//[InjectionConstructor]//构造函数注入：默认找参数最多的构造函数
        public ApplePhone(IHeadphone headphone)
        {
            this.iHeadphone = headphone;
            Console.WriteLine("{0}带参数构造函数", this.GetType().Name);
        }

        public void Call()
        {
            Console.WriteLine("{0}打电话", this.GetType().Name);
        }

        [InjectionMethod]//方法注入
        public void Init1234(IPower power)
        {
            this.iPower = power;
        }

		public void SendMsg()
		{
			MsgPrePare();
			GetReceivePerson();
			Console.WriteLine("{0}发短信", this.GetType().Name);
		}

		private void MsgPrePare()
		{
			Console.WriteLine("{0}信号准备", this.GetType().Name);
		}

		protected void GetReceivePerson()
		{
			Console.WriteLine("{0}获取接受人", this.GetType().Name);
		}
	}
}
