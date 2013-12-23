using System;
using System.Collections.Generic;
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
                Name = Request.Query;
                return Name;
            };
        }
    }

    public class LearningMultipleQueryParametersEndpoint : NancyModule
    {
        public static string Names = null;

        public LearningMultipleQueryParametersEndpoint()
        {
            Get["/learningMultipleQuery"] = Render;
        }

        private string Render(dynamic parameters)
        {
            Names = Request.Query.name;
            return Names;
        }
    }
}