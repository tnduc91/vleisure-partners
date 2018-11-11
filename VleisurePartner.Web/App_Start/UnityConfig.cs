using System;
using System.Configuration;
using System.Linq;
using Unity;
using Unity.AspNet.Mvc;
using Unity.Injection;
using Unity.RegistrationByConvention;
using VleisurePartner.Domain;
using VleisurePartner.EF;
using VleisurePartner.Logic.Transport;
using VleisurePartner.Web.App_Start;

namespace VleisurePartner.Web.App_Start
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public static class UnityConfig
    {
        private static string _assemblyVersion;
        private static string _assemblyDate;

        /// <summary>
        /// Gets the configured Unity container.
        /// </summary>
        public static IUnityContainer GetConfiguredContainer()
        {
            return Container.Value;
        }

        private static readonly Lazy<IUnityContainer> Container = new Lazy<IUnityContainer>(() =>
        {
            var assembly = System.Reflection.Assembly.GetAssembly(typeof(Startup));
            _assemblyVersion = assembly.GetName().Version.ToString();
            _assemblyDate = System.IO.File.GetLastWriteTime(assembly.Location)
                .ToString(System.Globalization.CultureInfo.CurrentCulture);

            var container = new UnityContainer();
            RegisterTypes(container);
            AutoRegisterInterfaces(container);
            return container;
        });

        private static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<IContext>(new PerRequestLifetimeManager(), new InjectionFactory(c =>
            {
                return new AppDbContext("VleisurePartnerDb");
            }));

            container.RegisterType<IEndPoint, EndPoint>(new InjectionConstructor(ConfigurationManager.AppSettings["vleisure:ApiEndPoint"]));
        }


        private static void AutoRegisterInterfaces(IUnityContainer container)
        {
            var allowedRootNamespaces = new[] {"VleisurePartner", ""};
            var excludedRootNamespaces = new[] {"VleisurePartner.EF", "VleisurePartner.Domain"};

            var interfacesWithOneImplementation = AllClasses.FromLoadedAssemblies()
                .Where(TypeNamespacesStartWith(allowedRootNamespaces))
                .Where(TypeNamespacesNotStartWith(excludedRootNamespaces))
                .SelectMany(t =>
                    t.GetInterfaces()
                        .Select(i => new
                        {
                            ClassType = t,
                            Interface = t.IsGenericType && i.IsGenericType
                                ? i.GetGenericTypeDefinition()
                                : i
                        }))
                .Where(x => !container.IsRegistered(x.Interface))
                .GroupBy(x => x.Interface)
                .Where(x => x.Count() == 1)
                .SelectMany(x => x);

            foreach (var registerTypePair in interfacesWithOneImplementation)
            {
                container.RegisterType(registerTypePair.Interface, registerTypePair.ClassType);
            }
        }

        private static Func<Type, bool> TypeNamespacesStartWith(string[] allowedRootNamespaces)
        {
            return t => allowedRootNamespaces.Any(allowedNamespace =>
                t.Namespace != null
                && t.Namespace.StartsWith(allowedNamespace, StringComparison.OrdinalIgnoreCase));
        }

        private static Func<Type, bool> TypeNamespacesNotStartWith(string[] excludedNamespaces)
        {
            return t => excludedNamespaces.All(excludedNamespace =>
                t.Namespace != null
                && !t.Namespace.StartsWith(excludedNamespace, StringComparison.OrdinalIgnoreCase));
        }
    }
}