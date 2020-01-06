using Domain.Context;
using Domain.Models;
using GraphQL.Types;
using GraphQLDomain.Types;
using System.Linq;

namespace GraphQLDomain.Operations.Querys
{
    public class EmployeeGroupQuery: ObjectGraphType<Employee>
    {
        public EmployeeGroupQuery(RepositoryContext repository)
        {
            Name = "Employees";
            Field<ListGraphType<EmployeeType>>().Name("AllEmployee").Resolve(context =>
            {
                return repository.Emplyee.ToList();
            });
        }
    }
}
