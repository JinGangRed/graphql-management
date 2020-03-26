using Management.Models.ReponseDtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Threading.Tasks;

namespace Management.Middlewares
{
    public class ValidateModelActionFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                var errors = context.ModelState.Keys
                    .SelectMany(key =>
                        context.ModelState[key].Errors
                        .Select(error =>
                            new ValidationError(key, error.ErrorMessage)));
                var result = new ResponseModel<IEnumerable<ValidationError>>
                {
                    Status = ResponseStatus.ValidModel,
                    Data = errors,
                };
                context.Result = new OkObjectResult(result);
            }
        }


    }
    public class ValidationError
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Field { get; }
        public string Message { get; }
        public ValidationError(string field, string message)
        {
            Field = field != string.Empty ? field : null;
            Message = message;
        }
    }
}
