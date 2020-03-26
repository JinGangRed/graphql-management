using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Management.Models.AuthConfigs
{
    public class AccessToken
    {
        public string Token { get; set; }
        public long Expires { get; set; }

        public string Username { get; set; }

        public string Role { get; set; }
    }
}
