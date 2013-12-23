using Nancy;

namespace Yose.World1
{
    public class AliveEndpoint : NancyModule
    {
        public AliveEndpoint()
        {
            Get["/ping"] = _ => Response.AsJson(new AliveResponse {alive = true});
        }
    }
}