using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Models
{
    public partial class Company : BaseEntity
    {
        [DisplayName("编号")]
        public int Id { get; set; }
        [DisplayName("公司名称")]
        [Required]
        public string Name { get; set; }
        [DisplayName("公司地址")]
        public Address Address { get; set; }
        [DisplayName("公司传真")]
        public string Fix { get; set; }

        [DisplayName("员工")]
        public ICollection<Employee> Emplyees { get; set; } = new List<Employee>();
    }
}
