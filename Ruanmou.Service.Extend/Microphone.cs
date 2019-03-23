using Ruanmou.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruanmou.Service
{
    public class Microphone : IMicrophone
    {

        //[Dependency]//属性注入
        //public ApplePhone ApplePhone { get; set; }
        public Microphone()
        {
            Console.WriteLine("Microphone 被构造");
        }
    }
}
