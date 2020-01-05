using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraphQLDomain.Models
{
    public class GraphQLSettings
    {
        public string Path { get; set; } = "api/graphql";

        public Func<HttpContext,IDictionary<string,object>> BuildUserContext { get; set; }

        public bool EnableMetrics { set; get; }
    }
}
