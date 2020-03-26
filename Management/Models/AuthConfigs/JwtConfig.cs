using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Management.Models.AuthConfigs
{
    public class JwtConfig
    {

        public string SecurityKey { get; set; }

        public string Issuer { get; set; }

        public double Expires { get; set; }

        public string Audience { get; set; }
    }
}
