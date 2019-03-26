using Ruanmou.Framework.DIOC;
using Ruanmou.IBLL;
using Ruanmou.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruanmou.Service
{
    public class AndroidPhone : IPhone
    {
        public IMicrophone iMicrophone { get; set; }
        public IHeadphone iHeadphone { get; set; }
        public IPower iPower { get; set; }
		public IBaseBll iBLL { get; set; }

		public AndroidPhone()
		{
			Console.WriteLine("{0}构造函数", this.GetType().Name);
		}

		public AndroidPhone(AbstractPad pad, IHeadphone headphone)
        {
            Console.WriteLine("{0}构造函数", this.GetType().Name);
        }

        //[ElevenInjectionConstructor]
        public AndroidPhone(AbstractPad pad)
        {
            Console.WriteLine("{0}构造函数", this.GetType().Name);
        }
        //public AndroidPhone(IBaseBll baseBll)
        //{
        //    Console.WriteLine("{0}构造函数", this.GetType().Name);
        //}

        public void Call()
        {
            Console.WriteLine("{0}打电话", this.GetType().Name); ;
        }
    }
}
