using GraphQL;
using GraphQL.Http;
using GraphQL.Types;
using GraphQLDomain.Models;
using Microsoft.AspNetCore.Http;
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using GraphQL.Validation;
using System.Net;
using Microsoft.AspNetCore.Http.Features;
using GraphQLDomain.Middlewares.ValidationRules;

namespace Management.Middlewares
{
    public class GraphQLMiddleware
    {
        private readonly RequestDelegate next;
        private readonly GraphQLSettings settings;

        private readonly IDocumentExecuter executer;
        private readonly IDocumentWriter writer;

        public GraphQLMiddleware(RequestDelegate next, GraphQLSettings settings, IDocumentExecuter executer, IDocumentWriter writer)
        {
            this.next = next;
            this.settings = settings;
            this.executer = executer;
            this.writer = writer;
        }

        public async Task Invoke(HttpContext context, ISchema schema)
        {
            if (!IsGraphQLRequest(context))
            {
                await next(context);
            }
            await ExecuteAsync(context, schema);
        }

        private bool IsGraphQLRequest(HttpContext context)
        {
            return context.Request.Path.StartsWithSegments(settings.Path)
                && string.Equals(context.Request.Method, "POST", StringComparison.OrdinalIgnoreCase);
        }

        private async Task ExecuteAsync(HttpContext context, ISchema schema)
        {
            
            var request = await DeserializeAsync<GraphQLRequest>(context.Request.Body);

            var result = await executer.ExecuteAsync(options =>
            {
                options.Schema = schema;
                options.Query = request?.Query;
                options.OperationName = request?.OperationName;
                options.Inputs = request?.Variables.ToInputs();
                options.UserContext = settings.BuildUserContext?.Invoke(context);
                options.ValidationRules = DocumentValidator.CoreRules.Concat(new[] { new AuthValidationRules() });
                options.EnableMetrics = settings.EnableMetrics;
            });
            await WriteResponseAsync(context, result);
        }

        private async Task WriteResponseAsync(HttpContext context, ExecutionResult result)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = result.Errors?.Any() == true ? (int)HttpStatusCode.BadRequest : (int)HttpStatusCode.OK;

            await writer.WriteAsync(context.Response.Body, result);
        }

        public static async Task<T> DeserializeAsync<T>(Stream stream) {

            using (var reader = new StreamReader(stream))
            {
                var result = await reader.ReadToEndAsync();
                return JsonConvert.DeserializeObject<T>(result);
            }
        }


    }
}
