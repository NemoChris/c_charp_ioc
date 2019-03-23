using Ruanmou.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruanmou.Service
{
    public class Power : IPower
    {
        public Power(IBLL.IBaseBll baseBll)
        {
            Console.WriteLine("Power 被构造");
        }
    }
}
