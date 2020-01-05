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
            Field<ListGraphType<UserTypes>>().Name("AllUsers").Resolve(context =>
            {
                return repository.Users.ToList();
            });
            Field<UserTypes>().Name("FirstUser").Resolve(context =>
            {
                return repository.Users.FirstOrDefault();
            });
        }
    }
}
