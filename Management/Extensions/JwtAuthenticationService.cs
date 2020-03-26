using Domain.Context;
using Management.Models.AuthConfigs;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Management.Extensions
{
    public static partial class ServiceExtensions
    {

        public static void ConfigureAuthentication(this IServiceCollection services, IConfiguration configuration)
        {
            var jwtConfig = configuration.GetSection("JWT").Get<JwtConfig>();
            
            if (jwtConfig.SecurityKey == null)
            {
                throw new Exception("Please config the SecurityKey in the Appsettings.json");
            }
            var issuerSigningKey = new MD5CryptoServiceProvider()
                .ComputeHash(Encoding.UTF8.GetBytes(jwtConfig.SecurityKey));

            services.AddAuthentication(options => {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidIssuer = jwtConfig.Issuer,

                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(issuerSigningKey),

                        ValidateAudience = true,
                        ValidAudience = jwtConfig.Audience,
                        ValidateLifetime = true,

                        ClockSkew = TimeSpan.FromSeconds(jwtConfig.Expires)
                    };

                    //options.Events = new JwtBearerEvents
                    //{
                    //    OnTokenValidated = OnTokenValidated

                    //};
                });
        }
    
    
        //private static Task OnTokenValidated(TokenValidatedContext context)
        //{
        //    var userContext = context.HttpContext.RequestServices.GetService<UserContext>().Users;
        //    var claims = context.Principal.Claims;
        //    userContext = long.Parse(claims.First(x => x.Type == JwtRegisteredClaimNames.Sub).Value);
        //    userContext.Account = claims.First(x => x.Type == ClaimTypes.NameIdentifier).Value;
        //    userContext.Name = claims.First(x => x.Type == ClaimTypes.Name).Value;
        //    userContext.Email = claims.First(x => x.Type == JwtRegisteredClaimNames.Email).Value;
        //    userContext.RoleId = claims.First(x => x.Type == ClaimTypes.Role).Value;

        //    return Task.CompletedTask;
        //}


    }
}
