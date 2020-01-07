using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Models
{
    public class User: BaseEntity
    {
        [DisplayName("编号")]
        public int Id { get; set; }
        [DisplayName("账号")]
        [Required]
        [StringLength(maximumLength:10,MinimumLength =6,ErrorMessage ="Please input 6-20 length for Account")]
        public string Account { get; set; }
        [DisplayName("密码")]
        [Required]
        [StringLength(maximumLength:100, MinimumLength =6)]
        public string Password { get; set; }
        [DisplayName("昵称")]
        public string NickName { get; set; }
        [DisplayName("姓名")]
        public string Name { get; set; }
    }
}
