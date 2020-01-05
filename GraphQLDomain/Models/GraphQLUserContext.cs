using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace GraphQLDomain.Models
{
    public class GraphQLUserContext:Dictionary<string,object>
    {
        public ClaimsPrincipal User { get; set; }
    }
}
