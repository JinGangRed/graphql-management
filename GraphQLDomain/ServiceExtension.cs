using Domain.Models;
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
            #region 基础类型
            services.AddSingleton<BaseEntityInterface>();
            services.AddSingleton<GenderEnumType>();
            services.AddSingleton<UserType>();
            services.AddSingleton<CompanyType>();
            services.AddSingleton<EmployeeType>();
            
            #endregion


            #region Query类型
            services.AddSingleton<Query>();
            services.AddSingleton<AccountGroupQuery>();
            services.AddSingleton<CompanyGroupQuery>();
            services.AddSingleton<EmployeeGroupQuery>();
            #endregion

            services.AddSingleton<ISchema,GraphSchema>();
        }
    }
}
