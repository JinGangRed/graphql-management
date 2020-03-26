using Domain.Context;
using GraphQL.Types;
using GraphQLDomain.Types;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphQLDomain.Operations.Querys
{
    public class Query:ObjectGraphType
    {
        public Query(RepositoryContext repository)
        {
            Name = "Query";
            //Field<AccountGroupQuery>("Account", resolve: context => new { });
            //Field<CompanyGroupQuery>("Company", resolve: context => new { });
            //Field<EmployeeGroupQuery>("Employees", resolve: context => new { });

            Field<ListGraphType<EmployeeType>>().Name("Employees").Resolve(context =>
            {
                return repository.Employee.AsEnumerable();
            });
            Field<ListGraphType<UserType>>().Name("AllUsers").Resolve(context =>
            {
                return repository.User.AsEnumerable();
            });
            Field<UserType>().Name("FirstUser").Resolve(context =>
            {
                return repository.User.FirstOrDefault();
            });
        }
    }
}
