using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace New
{
    public static class Bootstrapper
    {
        //public static IUnityContainer Initialise()
        //{
        //    var container = BuildUnityContainer();

        //    DependencyResolver.SetResolver(new UnityDependencyResolver(container));

        //    return container;
        //}

        //private static IUnityContainer BuildUnityContainer()
        //{
        //    var container = new UnityContainer();

        //    RegisterTypes(container);

        //    return container;
        //}

        //public static void RegisterTypes(IUnityContainer container)
        //{   
        //    string connectionString = WebConfigurationManager.ConnectionStrings["TestDBEntities"].ConnectionString;

        //    container.RegisterType<IDbContextFactory, DbContextFactory>(new HierarchicalLifetimeManager(), new InjectionConstructor(connectionString));

        //    // Repository
        //    container.RegisterType<IRepository<Categories>, GenericRepository<Categories>>();
        //    container.RegisterType<IRepository<Products>, GenericRepository<Products>>();

        //    // Service
        //    container.RegisterType<ICategoryService, CategoryService>();
        //    container.RegisterType<IProductService, ProductService>();

        //}
    }
}