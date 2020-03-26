using Extensions.Attribute;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Management.Extensions
{
    public class SwaggerHiddenAPIFilter : IDocumentFilter
    {
        public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
        {
            var keys = context.ApiDescriptions.Where(x =>
            {
                x.TryGetMethodInfo(out MethodInfo method);
                return method.ReflectedType.CustomAttributes.Any(t => t.AttributeType == typeof(HiddenAPIAttribute))
                || method.CustomAttributes.Any(t => t.AttributeType == typeof(HiddenAPIAttribute));
            }).Select(x =>
            {
                var key = $"/{x.RelativePath}";
                return key.Contains("?") ? key.Substring(key.IndexOf("?", StringComparison.Ordinal)) : key;
            }).DefaultIfEmpty();
            foreach (var item in keys)
            {
                swaggerDoc.Paths.Remove(item);
            }
        }
    }
}
