using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;

namespace GraphQLDomain.Utils
{
    public static class EntityHelper
    {
        public static string GetFiledDescription<TSourceType>(string name)
        {
            var type = typeof(TSourceType);
            try
            {
                var prop = type.GetProperty(name);
                if (prop != null)
                {
                    var displayAttribute = prop.GetCustomAttribute<DisplayNameAttribute>();
                    if(displayAttribute != null)
                    {
                        return displayAttribute.DisplayName;
                    }
                    return prop.Name;
                }
            }
            catch (Exception)
            {
                return "";
            }
            return "";
        }
    }
}
