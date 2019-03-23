//using Microsoft.Practices.Unity;
//using Microsoft.Practices.Unity.Configuration;
//using Ruanmou.Interface;
////using Ruanmou.Service;
////using Ruanmou.Service;
//using System;
//using System.Collections.Generic;
//using System.Configuration;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;
//using Unity;
//using Unity.Interception.ContainerIntegration;
//using Unity.Interception.Interceptors.InstanceInterceptors.InterfaceInterception;
//using Unity.Lifetime;
//using Unity.Registration;

//namespace Ruanmou.Project
//{
//    public class IOCTest
//    {
//        public static void Show()
//        {
//            Console.WriteLine("*******************直接实例化*******************");
//            {
//                ApplePhone phone = new ApplePhone();
//                Console.WriteLine($"phone.iHeadphone==null?  {phone.iHeadphone == null}");
//                Console.WriteLine($"phone.iMicrophone==null? {phone.iMicrophone == null}");
//                Console.WriteLine($"phone.iPower==null?      {phone.iPower == null}");
//            }
//            //1 Unity容器的初步应用
//            //2 多种注册，一对多注册
//            //3 依赖注入，多层架构
//            //4 生命周期管理
//            //5 配置文件使用
//            //6 AOP配置


//            #region MyRegion
//            //Console.WriteLine("*****************UnityAndroid*********************");
//            //{
//            //    IUnityContainer container = new UnityContainer();//1 空容器
//            //    container.RegisterType<IPhone, AndroidPhone>();//2 注册类型
//            //    container.RegisterType<AbstractPad, ApplePad>();
//            //    //container.RegisterType<ApplePad, ApplePadChild>();
//            //    container.RegisterInstance<ITV>(new AppleTV(123));


//            //    var phone = container.Resolve<IPhone>();
//            //    var pad = container.Resolve<AbstractPad>();
//            //    //var pad2 = container.Resolve<ApplePad>();
//            //    var tv = container.Resolve<ITV>();

//            //    Console.WriteLine($"phone.iHeadphone==null?  {phone.iHeadphone == null}");
//            //    Console.WriteLine($"phone.iMicrophone==null? {phone.iMicrophone == null}");
//            //    Console.WriteLine($"phone.iPower==null?      {phone.iPower == null}");
//            //}

//            //Console.WriteLine("*****************UnityAndroid*********************");
//            //{
//            //    IUnityContainer container = new UnityContainer();//1 空容器
//            //    container.RegisterType<IPhone, ApplePhone>();//2 注册类型
//            //    container.RegisterType<IPhone, AndroidPhone>("android");
//            //    container.RegisterType<IPhone, ApplePhone>("apple");

//            //    container.RegisterType<IHeadphone, Headphone>();
//            //    container.RegisterType<IMicrophone, Microphone>();
//            //    container.RegisterType<IPower, Power>();
//            //    var phone = container.Resolve<IPhone>();

//            //    Console.WriteLine($"phone.iHeadphone==null?  {phone.iHeadphone == null}");
//            //    Console.WriteLine($"phone.iMicrophone==null? {phone.iMicrophone == null}");
//            //    Console.WriteLine($"phone.iPower==null?      {phone.iPower == null}");

//            //    var android = container.Resolve<IPhone>("android");
//            //    var apple = container.Resolve<IPhone>("apple");
//            //}


//            //Console.WriteLine("*****************UnityApple*********************");
//            //{
//            //    IUnityContainer container = new UnityContainer();
//            //    container.RegisterType<IPhone, ApplePhone>();
//            //    container.RegisterType<IMicrophone, Microphone>();
//            //    container.RegisterType<IHeadphone, Headphone>();
//            //    container.RegisterType<IPower, Power>();

//            //    IPhone phone = container.Resolve<IPhone>();

//            //    Console.WriteLine($"phone.iHeadphone==null?  {phone.iHeadphone == null}");
//            //    Console.WriteLine($"phone.iMicrophone==null? {phone.iMicrophone == null}");
//            //    Console.WriteLine($"phone.iPower==null?      {phone.iPower == null}");
//            //}


//            //Console.WriteLine("*****************UnityContainer*********************");
//            //{
//            //    IUnityContainer container = new UnityContainer();
//            //    container.RegisterType<IPhone, ApplePhone>();
//            //    container.RegisterType<IPhone, ApplePhone>("Apple");
//            //    container.RegisterType<IPhone, AndroidPhone>("Android");
//            //    container.RegisterType<IMicrophone, Microphone>();
//            //    container.RegisterType<IHeadphone, Headphone>();
//            //    container.RegisterType<IPower, Power>();

//            //    IPhone iphone1 = container.Resolve<IPhone>();
//            //    iphone1.Call();
//            //    IPhone iphone2 = container.Resolve<IPhone>("Apple");
//            //    IPhone iphone3 = container.Resolve<IPhone>("Android");
//            //    IPhone iphone4 = container.Resolve<IPhone>();
//            //    IPhone iphone5 = container.Resolve<IPhone>();
//            //}

//            //Console.WriteLine("*****************UnityContainer*********************");
//            //{
//            //    //生命周期
//            //    IUnityContainer container = new UnityContainer();
//            //    //container.RegisterType<IPhone, AndroidPhone>();
//            //    ////container.RegisterType<IPhone, AndroidPhone>(new TransientLifetimeManager());//默认  瞬时  每一次都是全新生成
//            //    //container.RegisterType<IPhone, AndroidPhone>(new ContainerControlledLifetimeManager());//容器单例  单例就不要自己实现

//            //    container.RegisterType<IPhone, AndroidPhone>(new PerThreadLifetimeManager());//线程单例
//            //    var phone1 = container.Resolve<IPhone>();
//            //    var phone2 = container.Resolve<IPhone>();
//            //    Console.WriteLine(object.ReferenceEquals(phone1, phone2));

//            //    //container.RegisterType<IPhone, AndroidPhone>(new HierarchicalLifetimeManager());//分级容器单例
//            //    //IUnityContainer childContainer = container.CreateChildContainer();

//            //    //container.RegisterType<IPhone, AndroidPhone>(new ExternallyControlledLifetimeManager());//外部可释放单例
//            //    //container.RegisterType<IPhone, AndroidPhone>(new PerResolveLifetimeManager());//循环引用 不推荐
//            //    IPhone iphone1 = null;
//            //    Action act1 = new Action(() =>
//            //    {
//            //        iphone1 = container.Resolve<IPhone>();
//            //        Console.WriteLine($"iphone1由线程id={Thread.CurrentThread.ManagedThreadId}");
//            //    });
//            //    var result1 = act1.BeginInvoke(null, null);

//            //    IPhone iphone2 = null;
//            //    Action act2 = new Action(() =>
//            //    {
//            //        iphone2 = container.Resolve<IPhone>();
//            //        Console.WriteLine($"iphone2由线程id={Thread.CurrentThread.ManagedThreadId}");
//            //    });

//            //    IPhone iphone3 = null;
//            //    var result2 = act2.BeginInvoke(t =>
//            //    {
//            //        iphone3 = container.Resolve<IPhone>();
//            //        Console.WriteLine($"iphone3由线程id={Thread.CurrentThread.ManagedThreadId}");
//            //        Console.WriteLine($"object.ReferenceEquals(iphone2, iphone3)={object.ReferenceEquals(iphone2, iphone3)}");
//            //    }, null);

//            //    act1.EndInvoke(result1);
//            //    act2.EndInvoke(result2);

//            //    Console.WriteLine($"object.ReferenceEquals(iphone1, iphone2)={object.ReferenceEquals(iphone1, iphone2)}");
//            //}

//            //Console.WriteLine("*****************UnityContainer*********************");
//            //{
//            //    ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap();
//            //    fileMap.ExeConfigFilename = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "CfgFiles\\Unity.Config");//找配置文件的路径
//            //    Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);
//            //    UnityConfigurationSection section = (UnityConfigurationSection)configuration.GetSection(UnityConfigurationSection.SectionName);

//            //    IUnityContainer container = new UnityContainer();
//            //    section.Configure(container, "testContainer");

//            //    container.AddNewExtension<Interception>().Configure<Interception>()
//            //   .SetInterceptorFor<IPhone>(new InterfaceInterceptor());

//            //    IPhone phone = container.Resolve<IPhone>();
//            //    phone.Call();

//            //    IPhone android = container.Resolve<IPhone>("Android");
//            //    android.Call();
//            //}
//            //Console.WriteLine("*****************UnityContainer*********************");
//            //{
//            //    ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap();
//            //    fileMap.ExeConfigFilename = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "CfgFiles\\Unity.Config");//找配置文件的路径
//            //    Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);
//            //    UnityConfigurationSection section = (UnityConfigurationSection)configuration.GetSection(UnityConfigurationSection.SectionName);

//            //    IUnityContainer container = new UnityContainer();
//            //    section.Configure(container, "testContainerAOP");
//            //    IPhone phone = container.Resolve<IPhone>();
//            //    phone.Call();
//            //}
//            #endregion
//        }
//    }
//}
