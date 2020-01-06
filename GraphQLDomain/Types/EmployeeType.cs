using Domain.Models;
using GraphQL.Types;
using GraphQLDomain.Utils;

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
            //Field(e => e.Gender).Description(EntityHelper.GetFiledDescription<Company>("Gender"));
            Field(e => e.UpdateBy).Description(EntityHelper.GetFiledDescription<Company>("UpdateBy"));
            Field(e => e.UpdateTime, nullable: true).Description(EntityHelper.GetFiledDescription<Company>("UpdateTime"));
            Interface<BaseEntityInterface>();
        }
    }
}
