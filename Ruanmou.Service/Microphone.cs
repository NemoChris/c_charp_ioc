﻿using Ruanmou.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruanmou.Service
{
    public class Microphone : IMicrophone
    {

        public Microphone(IPower power)
        {
            Console.WriteLine("Microphone 被构造");
        }
    }
}
