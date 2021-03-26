using LearnRouting.Repository;
using System;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace LearnRouting
{
    public static class UnityConfig
    {
        public static Type IUserRepository { get; private set; }
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IUserMasterRepository, UserMasterRepository>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}