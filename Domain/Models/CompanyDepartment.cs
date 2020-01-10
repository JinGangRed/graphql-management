using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Domain.Models
{
    public class CompanyDepartment:BaseEntity
    {
        [DisplayName("公司ID")]
        public int CompanyId { get; set; }
        [DisplayName("部门ID")]
        public int DepartmentId { get; set; }
        [DisplayName("公司")]
        public virtual Company Company { get; set; }
        [DisplayName("部门")]
        public virtual Department Department { get; set; }
    }
}
