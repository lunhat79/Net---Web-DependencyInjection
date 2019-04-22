using Autofac;
using Autofac.Integration.WebApi;
using System.Reflection;
using System.Web.Http;

namespace DiWithAutofac
{
    public class AutofacConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var builder = new ContainerBuilder();

            var myAssembly = Assembly.GetExecutingAssembly();

            // Register IoC for Repository 
            builder.RegisterAssemblyTypes(myAssembly)
               .Where(t => t.Name.EndsWith("Repository"))
               .AsImplementedInterfaces();

            // Register IoC for Service 
            builder.RegisterAssemblyTypes(myAssembly)
               .Where(t => t.Name.EndsWith("Service"))
               .AsImplementedInterfaces();

            // Register IoC for Controller 
            builder.RegisterApiControllers(myAssembly);

            // Config Autofac
            var container = builder.Build();

            var autofacResolver = new AutofacWebApiDependencyResolver(container);
            config.DependencyResolver = autofacResolver;
        }
    }
}