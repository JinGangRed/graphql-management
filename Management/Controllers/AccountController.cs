using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Management.Models.AuthConfigs;
using Management.Models.ReponseDtos;
using Management.Models.UserDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Management.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private IConfiguration Configuration;
        public AccountController(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        [HttpPost]
        public ResponseModel<AccessToken> AccessToken([FromBody]UserLoginModel user)
        {
            var result = new ResponseModel<AccessToken>
            {
                Message = "发生错误",
                Status = ResponseStatus.Fail
            };
            // 验证用户
            var claims = new Claim[]
            {
                new Claim(ClaimTypes.Name,user.Username),
                new Claim(ClaimTypes.NameIdentifier,user.Password),
                new Claim(ClaimTypes.Role,"1")
            };

            var jwtConfig = Configuration.GetSection("JWT").Get<JwtConfig>();

            if (jwtConfig.SecurityKey == null)
            {
                throw new Exception("Please config the SecurityKey in the Appsettings.json");
            }
            var md5SecurityKey = new MD5CryptoServiceProvider()
                .ComputeHash(Encoding.UTF8.GetBytes(jwtConfig.SecurityKey));
            var issuerSigningKey = new SymmetricSecurityKey(md5SecurityKey);
            var expires = DateTime.Now.AddSeconds(Convert.ToDouble(jwtConfig.Expires));
            var token = new JwtSecurityToken(
                issuer: jwtConfig.Issuer,
                audience: jwtConfig.Audience,
                claims: claims,
                notBefore: DateTime.Now,
                expires: expires,
                signingCredentials: new SigningCredentials(issuerSigningKey, SecurityAlgorithms.HmacSha256));

            var jwtToken = new JwtSecurityTokenHandler().WriteToken(token);
            result.Status = ResponseStatus.OK;
            result.Data = new AccessToken() { 
                Token = jwtToken, 
                Expires = expires.ToFileTimeUtc(),
                Username = user.Username,
                Role = "1111",
            };
            result.Message = "登录成功";
            return result;
        }
    }
}