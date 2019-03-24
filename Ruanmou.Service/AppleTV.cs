using Ruanmou.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruanmou.Service
{
    public class AppleTV : ITV
    {
		public int Id { get; set; }
		public AppleTV(int id)
        {
			this.Id = id;
        }
        public void Show()
        {
            Console.WriteLine($"This is {nameof(AppleTV)}");
        }
    }
}
