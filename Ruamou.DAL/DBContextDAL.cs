using Ruanmou.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruamou.DAL
{
    public class DBContextDAL<T> : IDBContext<T>
    {
        public void DoNothing()
        {
            Console.WriteLine($"......{typeof(T)}.....");
        }
    }
}
