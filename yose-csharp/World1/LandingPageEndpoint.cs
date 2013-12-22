using Nancy;

namespace Yose.World1
{
    public class LandingPageEndpoint : NancyModule
    {
        public LandingPageEndpoint()
        {
            Get["/"] = _ => View["index.html"];
        }
    }
}