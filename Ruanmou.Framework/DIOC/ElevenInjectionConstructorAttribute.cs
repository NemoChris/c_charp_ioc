using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruanmou.Framework.DIOC
{
    [AttributeUsage(AttributeTargets.Constructor)]
    public sealed class ElevenInjectionConstructorAttribute : Attribute
    {
        public ElevenInjectionConstructorAttribute()
        { }
    }
}
