using System;
using System.Collections.Generic;
using System.Text;

namespace Extensions.Attribute
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
    public partial class HiddenAPIAttribute : System.Attribute { }
}
