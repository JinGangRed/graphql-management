using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Utilities.Strings;

namespace Domain.SeedData
{
    public class InitUser
    {
        public IEnumerable<User> GetInitData(int num = 10)
        {
            var users = new List<User>();
            for (int i = 0; i < num; i++)
            {
                users.Add(new User
                {
                    Id = i + 1,
                    Account = new Random().Next(100000, int.MaxValue).ToString(),
                    Password = new Random().Next(100000, int.MaxValue).ToString(),
                    CreateBy = "System",
                    UpdateBy = "System",
                    CreateTime = DateTime.Now,
                    NickName = StringExtensions.GenerateChineseName(),
                    Name = StringExtensions.GenerateChineseName(false)
                }); 
            }
            return users;
        }
    }
}
