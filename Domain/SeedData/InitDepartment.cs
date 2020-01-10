using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Utilities.Strings;

namespace Domain.SeedData
{
    public class InitDepartment
    {
        public IEnumerable<Department> GetInitData(int num = 10)
        {
            var departments = new List<Department>();
            for (int i = 0; i < num; i++)
            {
                departments.Add(new Department
                {
                    Id = i + 1,
                    CreateBy = "System",
                    UpdateBy = "System",
                    Name = StringExtensions.GenerateChineseName(),
                    CreateTime = DateTime.Now,
                });
            }
            return departments;
        }
    }
}
