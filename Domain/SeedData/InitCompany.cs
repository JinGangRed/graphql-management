using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.SeedData
{
    public class InitCompany
    {
        public IEnumerable<Company> GetInitData(int num = 10)
        {
            var companies = new List<Company>();
            for (int i = 0; i < num; i++)
            {
                companies.Add(new Company
                {
                    Id = i + 1,
                    CreateBy = "System",
                    UpdateBy = "System",
                    Name = InitHelper.GenerateChineseWord(new Random().Next(12, 20)),
                    Address = new Address
                    {
                        City = "长沙",
                        Country = "中国",
                        Province = "湖南",
                        Region = "华南",
                        Street = "12号"
                    },
                    Fix = new Random().Next(100000,999999).ToString(),
                    CreateTime = DateTime.Now,
                }); ;
            }
            return companies;
        }
    }
}
