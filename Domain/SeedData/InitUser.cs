using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Utilities.Strings;

namespace Domain.SeedData
{
    public class InitUser
    {
        public IEnumerable<User> GetInitData()
        {
            var users = new List<User>();
            users.Add(new User
            {
                Id =  1,
                Account = "Admin",
                Password = "Admin",
                CreateBy = "System",
                UpdateBy = "System",
                CreateTime = DateTime.Now,
                NickName = ChineseCharacter.GenerateChineseName(),
                Name = ChineseCharacter.GenerateChineseName()
            });
            return users;
        }
    }
}
