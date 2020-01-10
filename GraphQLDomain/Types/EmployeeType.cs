using Domain.Models;
using GraphQL.Types;
using GraphQLDomain.Utils;
using Utilities.Entity;

namespace GraphQLDomain.Types
{
    public class EmployeeType:ObjectGraphType<Employee>
    {
        public EmployeeType()
        {
            Name = "Employee";
            Field(e => e.Id).Description(EntityHelper.GetFiledDescription<Company>("Id"));
            Field(e => e.Name).Description(EntityHelper.GetFiledDescription<Company>("Name"));
            Field(e => e.Contact).Description(EntityHelper.GetFiledDescription<Company>("Contact"));
            Field(e => e.CreateBy).Description(EntityHelper.GetFiledDescription<Company>("CreateBy"));
            Field(e => e.CreateTime, nullable: true).Description(EntityHelper.GetFiledDescription<Company>("CreateTime"));
            Field<GenderEnumType>(name: "gender",
                description: EntityHelper.GetFiledDescription<Company>("Gender"),
                resolve: context => context.Source.Gender);
            Field<CompanyType>().Name("Company").Resolve(context => context.Source.Company).Description(EntityHelper.GetFiledDescription<Company>("Company"));
            Field(e => e.UpdateBy).Description(EntityHelper.GetFiledDescription<Company>("UpdateBy"));
            Field(e => e.UpdateTime, nullable: true).Description(EntityHelper.GetFiledDescription<Company>("UpdateTime"));
            Interface<BaseEntityInterface>();
        }
    }
}
