using Domain.Context;
using GraphQL.Types;
using GraphQLDomain.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphQLDomain.Operations.Querys
{
    public class AccountGroupQuery: ObjectGraphType
    {
        public AccountGroupQuery(RepositoryContext repository)
        {
            Name = "Account";
            Field<ListGraphType<UserType>>().Name("AllUsers").Resolve(context =>
            {
                return repository.User.ToList();
            });
            Field<UserType>().Name("FirstUser").Resolve(context =>
            {
                return repository.User.FirstOrDefault();
            });
        }
    }
}
