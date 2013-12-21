using System;
using Nancy;
using Nancy.Hosting.Self;

namespace Yose
{
    public class Server
    {
        public const string Host = "localhost";
        public const string Port = "5000";

        public void Start()
        {
            var hostConfiguration = new HostConfiguration();
            hostConfiguration.UrlReservations.CreateAutomatically = true;
            StaticConfiguration.DisableErrorTraces = false;
            var baseUris = new Uri(String.Format("http://{0}:{1}", Host, Port));

            var host = new NancyHost(hostConfiguration, baseUris);
            host.Start();
        }
    }
}