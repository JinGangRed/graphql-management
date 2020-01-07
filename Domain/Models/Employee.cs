using System.ComponentModel;

namespace Domain.Models
{
    public class Employee:BaseEntity
    {
        [DisplayName("编号")]
        public int Id { get; set; }
        [DisplayName("员工名")]
        public string Name { get; set; }
        [DisplayName("员工号")]
        public string EmployeeNo { get; set; }
        [DisplayName("联系方式")]
        public string Contact { get; set; }
        [DisplayName("性别")]
        public Gender Gender { get; set; }
        [DisplayName("员工公司")]
        public Company Company { get; set; } = new Company();
        [DisplayName("部门编号")]
        public int DepartmentId { get; set; }
        [DisplayName("所在部门")]
        public Department Department { get; set; } = new Department();
    }
}
