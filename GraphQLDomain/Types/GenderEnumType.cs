using Domain.Models;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;
using Utilities.Entity;

namespace GraphQLDomain.Types
{
    public class GenderEnumType: EnumerationGraphType<Gender>
    {
        public GenderEnumType()
        {
            Name = "Gender";
            Description = "性别";
            AddValue(Gender.UnKnown.ToString(), Gender.UnKnown.GetEnumDescription(), Gender.UnKnown);
            AddValue(Gender.Male .ToString(), Gender.Male.GetEnumDescription(), Gender.Male);
            AddValue(Gender.Female .ToString(), Gender.Female.GetEnumDescription(), Gender.Female);
        }
    }
}
