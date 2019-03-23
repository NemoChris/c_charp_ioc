using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruanmou.Project
{
    public class EFIOCTest
    {
        public static void Show()
        {
            //using (JDContext context = new JDContext())
            //{
            //    User user = context.Set<User>().Find(2);
            //}

            //UserService service = new UserService();
            ////User user = service.Find(2);
            //User user = service.Find<User>(2);

            //IUserMenuService service = new UserMenuService();
            //User user = service.Find<User>(2);
            //service.UserLastLogin(user);

            //IUnityContainer container = new UnityContainer();
            //container.RegisterType<IBaseService, BaseService>();
            //container.RegisterType<IUserMenuService, UserMenuService>();
            //container.RegisterType<DbContext, JDContext>();

            //using (IUserMenuService service = container.Resolve<IUserMenuService>())
            //{
            //    User user = service.Find<User>(2);
            //}


            //ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap();
            //fileMap.ExeConfigFilename = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "CfgFiles\\Unity.Config.xml");//找配置文件的路径
            //Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);
            //UnityConfigurationSection section = (UnityConfigurationSection)configuration.GetSection(UnityConfigurationSection.SectionName);

            //IUnityContainer container = new UnityContainer();
            //section.Configure(container, "ruanmouContainer");

            //ICategoryService categoryService = container.Resolve<ICategoryService>();
            //Category category = categoryService.Find(1);
            //categoryService.Update(category);
            //categoryService.Show();

            //IBaseService<Category> iBaseServie = container.Resolve<IBaseService<Category>>();

            //Category category1 = iBaseServie.Find(1);
        }
    }
}
