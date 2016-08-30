using Autofac;
using Autofac.Integration.Mvc;
using DIUsingAutoFactMVC5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DIUsingAutoFactMVC5.App_Start
{
    public static class AutoFactConfig
    {
        //manually created
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<BlogService>().As<IServiceBlog>();
            builder.RegisterControllers(typeof(MvcApplication).Assembly).PropertiesAutowired();
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}