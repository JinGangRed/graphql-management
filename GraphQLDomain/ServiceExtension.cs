using GraphQL;
using GraphQL.Http;
using GraphQL.Types;
using GraphQLDomain.Operations.Querys;
using GraphQLDomain.Types;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraphQLDomain
{
    public static partial class ServiceExtension
    {
        public static void ConfigureGraphQL(this IServiceCollection services)
        {
            services.AddSingleton<IDocumentExecuter, DocumentExecuter>();
            services.AddSingleton<IDocumentWriter, DocumentWriter>();
            services.AddSingleton<Query>();
            services.AddSingleton<AccountGroupQuery>();
            services.AddSingleton<BaseEntityInterface>();
            services.AddSingleton<UserTypes>();
            services.AddSingleton<ISchema,GraphSchema>();
        }
    }
}
