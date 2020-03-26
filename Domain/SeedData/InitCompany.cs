using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Utilities.Strings;

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
                    Name = ChineseCharacter.GenerateChineseName(),
                    Fix = new Random().Next(100000, 999999).ToString(),
                    CreateTime = DateTime.Now,
                });
            }
            return companies;
        }
    }
}
