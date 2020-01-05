using GraphQL;
using GraphQL.Types;
using GraphQLDomain.Operations.Querys;
using System;

namespace GraphQLDomain
{
    public class GraphSchema : Schema
    {
        public GraphSchema(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            Query = serviceProvider.GetService(typeof(Query)) as IObjectGraphType;
        }
    }
}
