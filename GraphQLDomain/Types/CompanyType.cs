using Domain.Models;
using GraphQL.Types;
using GraphQLDomain.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using Utilities.Entity;

namespace GraphQLDomain.Types
{
    public class CompanyType:ObjectGraphType<Company>
    {
        public CompanyType()
        {
            Name = "Company";
            Field(u => u.Id).Description(EntityHelper.GetFiledDescription<Company>("Id"));
            Field(u => u.Name,nullable:false).Description(EntityHelper.GetFiledDescription<Company>("Name"));
            //Field(u => u.Address).Description(EntityHelper.GetFiledDescription<Company>("Address"))
            //    .Resolve(context =>
            //    {
            //        return context.Source.Address;
            //    });


            Field(u => u.CreateBy).Description(EntityHelper.GetFiledDescription<Company>("CreateBy"));
            Field(u => u.CreateTime, nullable: true).Description(EntityHelper.GetFiledDescription<Company>("CreateTime"));
            Field(u => u.Fix).Description(EntityHelper.GetFiledDescription<Company>("Fix"));
            Field(u => u.UpdateBy).Description(EntityHelper.GetFiledDescription<Company>("UpdateBy"));
            Field(u => u.UpdateTime, nullable: true).Description(EntityHelper.GetFiledDescription<Company>("UpdateTime"));

            Interface<BaseEntityInterface>();
        }
    }
}
