using GraphQL.Language.AST;
using GraphQL.Validation;
using GraphQLDomain.Utils;
using GraphQLDomain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GraphQLDomain.Middlewares.ValidationRules
{
    public class AuthValidationRules : IValidationRule
    {
        private ValidationContext Context;
        public Task<INodeVisitor> ValidateAsync(ValidationContext context)
        {
            Context = context;

            return Task.FromResult(new EnterLeaveListener(GetEnterLeaveListener) as INodeVisitor);

        }
        private void GetEnterLeaveListener(EnterLeaveListener configure)
        {
            configure.Match<Operation>(operation =>
            {
                if(operation.OperationType == OperationType.Mutation)
                {
                    Context.ReportError(
                        new ValidationError(
                           originalQuery: Context.OriginalQuery,
                        errorCode: "Need Auth",
                        message: $"Authorization is required to access {operation.Name}",
                        operation
                        ));
                }
            });

            configure.Match<Field>(field =>
            {
                var user = Context.UserContext as GraphQLUserContext;
                var fieldDef = Context.TypeInfo.GetFieldDef();
                
                if (fieldDef != null && fieldDef.RequirePermissions() && fieldDef.CanAccess(user.User?.Claims))
                {
                    Context.ReportError(new ValidationError(
                        originalQuery: Context.OriginalQuery,
                        errorCode: "Need Auth",
                        message: $"You are not authorized to run this query.",
                        field));
                }
            });
        }

    }
}
