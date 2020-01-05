using Domain.Models;
using GraphQL;
using GraphQL.Types;
using GraphQLDomain.Utils;
using System;

namespace GraphQLDomain.Types
{
    public class UserTypes: ObjectGraphType<User>
    {
        public UserTypes()
        {
            Name = "User";
            Field(u => u.Id).Description(EntityHelper.GetFiledDescription<User>("Id"));
            Field(u => u.NickName).Description(EntityHelper.GetFiledDescription<User>("NickName"));
            Field(u => u.CreateBy).Description(EntityHelper.GetFiledDescription<User>("CreateBy"));
            Field(u => u.CreateTime,nullable:true).Description(EntityHelper.GetFiledDescription<User>("CreateTime"));
            Field(u => u.Account).Description(EntityHelper.GetFiledDescription<User>("Account"));
            Field(u => u.UpdateBy).Description(EntityHelper.GetFiledDescription<User>("UpdateBy"));
            Field(u => u.UpdateTime, nullable: true).Description(EntityHelper.GetFiledDescription<User>("UpdateTime"));
            Interface<BaseEntityInterface>();
        }
    }
}
