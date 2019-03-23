using Ruamou.DAL;
using Ruanmou.IBLL;
using Ruanmou.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruanmou.BLL
{
    public class BaseBll : IBaseBll
    {
        private IBaseDAL _baseDAL = null;
        public BaseBll(IBaseDAL baseDAL, int id)
        {
            Console.WriteLine($"{nameof(BaseBll)}被构造。。。{id}。");
            this._baseDAL = baseDAL;
        }
        public void DoSomething()
        {
            this._baseDAL.Add();
            this._baseDAL.Update();
            this._baseDAL.Find();
            this._baseDAL.Delete();
        }
    }
}
