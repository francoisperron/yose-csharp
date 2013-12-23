using Nancy;

namespace Yose.World1
{
    public class AliveNancyEndpoint : NancyModule
    {
        public AliveNancyEndpoint()
        {
            Get["/ping"] = _ => Response.AsJson(new AliveResponse {alive = true});
        }
    }
}