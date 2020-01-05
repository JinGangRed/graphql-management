using Domain.Models;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraphQLDomain.Types
{
    public class BaseEntityInterface: InterfaceGraphType<BaseEntity>
    {
        public BaseEntityInterface()
        {
            Name = "BaseEntity";
            Description = "基础实体类型";
            Field(b => b.CreateBy).Description("创建者");
            Field(b => b.CreateTime, nullable: true).Description("创建时间");
            Field(b => b.UpdateBy).Description("更新者");
            Field(b => b.UpdateTime, nullable: true).Description("更新时间");
        }


    }
}
