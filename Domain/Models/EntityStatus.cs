using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Domain.Models
{
    public enum EntityStatus
    {
        [Description("启用中")]
        Active,
        [Description("未启用")]
        InActive,
        [Description("异常")]
        OnException

    }
}
