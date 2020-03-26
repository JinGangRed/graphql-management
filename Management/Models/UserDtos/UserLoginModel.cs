using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Management.Models.UserDtos
{
    [DataContract]
    public class UserLoginModel
    {
        [DataMember(Order = 2)]
        [Required(ErrorMessage ="用户名不能为空")]
        public string Username { get; set; }

        [DataMember(Order = 1)]
        [Required(ErrorMessage = "密码不能为空")]
        public string Password { get; set; }
    }
}
