using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Extensions.Attribute;
using GraphQL;
using GraphQL.Types;
using GraphQL.Validation;
using GraphQLDomain.Middlewares.ValidationRules;
using GraphQLDomain.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Management.Controllers
{
    [Route("/api/graphql")]
    public class GraphQLController : Controller
    {
        private IDocumentExecuter executer;
        private ISchema schema;

        public GraphQLController(IDocumentExecuter executer, ISchema schema)
        {
            this.executer = executer;
            this.schema = schema;
        }
        [HiddenAPI]
        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] GraphQLRequest query)
        {

            var result = await executer.ExecuteAsync(options =>
            {
                options.Schema = schema;
                options.Query = query?.Query;
                options.OperationName = query?.OperationName;
                options.Inputs = query?.Variables.ToInputs();
                //options.UserContext = HttpContext.User;
                options.ValidationRules = DocumentValidator.CoreRules.Concat(new[] { new AuthValidationRules() });
            });
            if(result.Errors?.Count > 0)
            {
                return BadRequest(result.Errors);
            }
            return Ok(result);
        }

    }
}
