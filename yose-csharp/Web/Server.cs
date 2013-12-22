using System;
using System.IO;
using Nancy;
using Nancy.Hosting.Self;

namespace Yose.Web
{
    public class Server
    {
        public const string Uri = "http://localhost:5000";

        public void Start()
        {
            StaticConfiguration.DisableErrorTraces = false;
            var hostConfiguration = new HostConfiguration {UrlReservations = {CreateAutomatically = true}};            
            var baseUris = new Uri(Uri);
            var host = new NancyHost(hostConfiguration, baseUris);
            host.Start();
        }
    }

    public class CustomBootstrapper : DefaultNancyBootstrapper
    {
        protected override IRootPathProvider RootPathProvider
        {
            get { return new CustomRootPathProvider(); }
        }
    }

    public class CustomRootPathProvider : IRootPathProvider
    {
        public string GetRootPath()
        {
            return AppDomain.CurrentDomain.BaseDirectory + "views";
        }
    }
}
