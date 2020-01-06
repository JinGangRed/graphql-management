using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Domain.Models
{
    public enum Gender
    {
        [Description("未知")]
        UnKnown,
        [Description("男")]
        Male,
        [Description("女")]
        Female,
      
    }
}
