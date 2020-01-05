using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

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
                    NickName = InitHelper.GenerateChineseWord(new Random().Next(4, 8))
                }); 
            }
            return users;
        }


    }
}
