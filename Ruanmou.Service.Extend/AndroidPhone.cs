using Ruanmou.IBLL;
using Ruanmou.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
		//默认构造参数最多的函数
		public AndroidPhone(IBaseBll iBLL, IPower iPower, IHeadphone iHeadphone, IMicrophone iMicrophone)
        {
			this.iBLL = iBLL;
			this.iPower = iPower;
			this.iHeadphone = iHeadphone;
			this.iMicrophone = iMicrophone;
            Console.WriteLine("{0}构造函数", this.GetType().Name);
        }

        public void Call()
        {
            Console.WriteLine("{0} Extend打电话", this.GetType().Name); ;
        }
    }
}
