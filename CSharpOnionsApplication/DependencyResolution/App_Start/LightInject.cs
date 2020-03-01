using Core;
using DataAccess.Repositories;
using Domain.Person;
using LightInject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(DependencyResolution.App_Start.LightInject), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethod(typeof(DependencyResolution.App_Start.LightInject), "Stop")]

namespace DependencyResolution.App_Start
{
    public static class LightInject
    {
        private static readonly ServiceContainer container = new ServiceContainer();

        public static void Start()
        {
            RegisterServices();

            container.RegisterControllers(typeof(Web.MvcApplication).Assembly);
            container.EnableMvc();
        }

        public static void Stop()
        {

        }

        private static void RegisterServices()
        {
            //Repositories
            container.Register<IPersonRepository, PersonRepository>();

            //Facades
            container.Register<IEntitiesFascade, EntitiesFascade>();
            container.Register<IServicesFascade, ServicesFascade>();
            container.Register<IApplicationFascade, ApplicationFascade>();
        }
    }
}
