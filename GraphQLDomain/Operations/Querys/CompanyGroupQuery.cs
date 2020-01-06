using Domain.Context;
using GraphQL.Types;
using GraphQLDomain.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphQLDomain.Operations.Querys
{
    public class CompanyGroupQuery : ObjectGraphType
    {
        public CompanyGroupQuery(RepositoryContext repository)
        {
            Name = "Companys";
            Field<ListGraphType<CompanyType>>().Name("AllCompany").Resolve(context =>
            {
                return repository.Company.ToList();
            });
        }
    }
}
