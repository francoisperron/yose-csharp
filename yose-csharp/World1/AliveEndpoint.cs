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

    public class AliveResponse
    {
        public bool alive { get; set; }
    }
}