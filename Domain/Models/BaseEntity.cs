using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Models
{
    public class BaseEntity
    {
        [DisplayName("创建时间")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? CreateTime { get; set; }
        [DisplayName("创建人")]
        public string CreateBy { get; set; }
        [DisplayName("更新时间")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdateTime { get; set; }
        [DisplayName("更新人")]
        public string UpdateBy { get; set; }
        [DisplayName("数据状态")]
        public EntityStatus Status { get; set; }
    }
}
