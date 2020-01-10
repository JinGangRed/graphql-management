using System.Collections.Generic;
using System.ComponentModel;

namespace Domain.Models
{
    public class Department:BaseEntity
    {
        [DisplayName("编号")]
        public int Id { get; set; }
        [DisplayName("部门名称")]
        public string Name { get; set; }
        [DisplayName("部门号")]
        public string DepartmentNo { get; set; }
        
        [DisplayName("部门员工")]
        public virtual IEnumerable<Employee> Employees { get; set; } = new List<Employee>();
    }
}
