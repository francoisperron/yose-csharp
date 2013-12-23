using Nancy;

namespace Yose.Web
{
    public class LearningUrlParametersEndpoint : NancyModule
    {
        public static string Name;

        public LearningUrlParametersEndpoint()
        {
            Get["/learning/{name}"] = parameters =>
            {
                Name = parameters.name;
                return Name;
            };
        }
    }

    public class LearningQueryParametersEndpoint : NancyModule
    {
        public static string Name;

        public LearningQueryParametersEndpoint()
        {
            Get["/learningQuery"] = _ =>
            {
                Name = Request.Query.name;
                return Name;
            };
        }
    }
}