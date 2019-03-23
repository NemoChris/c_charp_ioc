//using Ruanmou.Interface;
//using Ruanmou.Service;
////using Ruanmou.Service;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Ruanmou.Project
//{
//    public class Student
//    {
//        /// <summary>
//        /// 面向细节：参数类型写死了  只能为一种手机服务
//        /// </summary>
//        /// <param name="phone"></param>
//        public void PlayApplePhone(ApplePhone phone)
//        {
//            phone.Call();
//        }

//        /// <summary>
//        /// 面向细节：参数类型写死了  只能为一种手机服务
//        /// 手机扩展  增加了别的类型？ 修改这个student
//        /// </summary>
//        /// <param name="phone"></param>
//        public void PlayAndroidPhone(AndroidPhone phone)
//        {
//            phone.Call();
//        }

//        /// <summary>
//        /// 面向抽象：可以适配更多类型 
//        /// 手机类型扩展，也不用修改
//        /// </summary>
//        /// <param name="phone"></param>
//        public void PlayPhone(IPhone phone)
//        {
//            phone.Call();
//        }

//    }
//}
