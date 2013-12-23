using Nancy;

namespace Yose.World1
{
    public class LandingPageNancyEndpoint : NancyModule
    {
        public LandingPageNancyEndpoint()
        {
            Get["/"] = _ => View["index.html"];
        }
    }
}