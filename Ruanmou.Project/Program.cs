using Microsoft.Practices.Unity.Configuration;
using Ruamou.DAL;
using Ruanmou.Framework.DIOC;
using Ruanmou.IDAL;
using Ruanmou.Interface;
using Ruanmou.Service;
//using Ruanmou.Service;
//using Ruanmou.Service;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Unity;
using Unity.Interception;
using Unity.Interception.Interceptors.InstanceInterceptors.InterfaceInterception;
using Unity.Lifetime;

namespace Ruanmou.Project
{
    /// <summary>
    /// 1 从依赖倒置原则到IOC控制反转实现
    /// 2 从手写工厂+配置文件+反射到DI依赖注入实现
    /// 3 手写IOC容器，递归完成构造函数注入
    /// 
    /// 分层架构是必须的,可以划分边界独立演化，也方便分工，代码复用
    /// 依赖倒置原则DIP：系统架构时，高层模块不应该依赖于低层模块，二者通过抽象来依赖， 依赖抽象，而不是细节
    /// 面向抽象：1 一个方法能满足多种类型   2 支持下层的扩展
    /// 
    /// IOC控制反转：传统开发，上端依赖(调用/指定)下端对象，会有依赖
    ///              把对下端对象的依赖转移到第三方容器(工厂+配置文件+反射)
    ///              能够程序拥有更好的扩展性
    ///              
    ///  DI依赖注入：依赖注入就是能做到构造某个对象时，将依赖的对象自动初始化并注入 
    ///              三种注入方式：构造函数注入--属性注入--方法注入(按时间顺序)
    ///              构造函数注入用的最多，默认找参数最多的构造函数，可以不用特性，可以去掉对容器的依赖
    ///    IOC是目标是效果，需要DI依赖注入的手段
    ///    
    /// 如何使用Unity容器
    /// 1 nuget添加Unity5.9.7
    /// 2 容器三部曲
    /// 3 项目版本和服务层的版本要一致
    /// 
    /// 
    /// 1 Unity生命周期管理/配置文件/特殊类型
    /// 2 手写IOC容器，解读IOC的实现
    /// 3 Unity的AOP应用
    /// 
    /// 到课率请多多用心，大家很忙，即使真的没法上课，希望大家能够把课程挂起来，自己忙自己的， 谢谢大家多多配合
    /// 到课率==你上的课/你能上的课
    /// 高级班的传统，准备好学习的小伙伴儿，给Eleven老师刷个专属字母E，然后课程就正式开始了！！！
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
				//Demo1 - 利用反射手动实现IOC
				//Demo.Demo1.Run();
				//Demo2-创建对象依赖链依赖于细节展示
				//Demo.Demo2.Run();
				//Demo3-Unity容器的初步应用
				Demo.Demo3.Run();				

			}
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}
