using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Management.Models.ReponseDtos
{
    public enum ResponseStatus
    {
        [Description("请求成功")]
        OK = 20000,
        [Description("请求失败")]
        Fail = 40000,

        [Description("数据验证失败")]
        ValidModel = 40001,

    }
}
