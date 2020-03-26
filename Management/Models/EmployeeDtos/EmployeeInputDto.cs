using Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Management.Models.EmployeeDtos
{
    public class EmployeeInputDto
    {
        [DisplayName("员工名")]
        [Required(ErrorMessage = "姓名不能为空")]
        public string Name { get; set; }
        [DisplayName("联系方式")]
        public string Contact  { get; set; }
        [DisplayName("性别")]
        public Gender Gender { get; set; }
    }
}
