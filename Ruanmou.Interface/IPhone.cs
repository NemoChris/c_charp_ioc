using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ruanmou.Framework;
using Ruanmou.Framework.AOP;

namespace Ruanmou.Interface
{
	[UserHandler(Order =3)]
	[LogHandler(Order = 5)]
	public interface IPhone
	{		
        void Call();
		void SendMsg();
        IMicrophone iMicrophone { get; set; }
        IHeadphone iHeadphone { get; set; }
        IPower iPower { get; set; }
		IBLL.IBaseBll iBLL { get; set; }		
	}
}
