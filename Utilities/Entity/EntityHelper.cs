using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Utilities.Entity
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


        public static string GetEnumDescription(this Enum @enum)
        {
            var type = @enum.GetType();

            var fieldInfo = type.GetField(@enum.ToString());

            var attributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute));
            if(attributes == null || attributes.Count() > 0)
            {
                return @enum.ToString();
            }
            return attributes.LastOrDefault().Description;
        }
    }
}
