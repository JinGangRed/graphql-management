using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Utilities.Strings
{
    public class JsonHelper
    {
        public static T GetObjectFromJson<T>(string path)
        {
            return JsonConvert.DeserializeObject<T>(File.ReadAllText(path,Encoding.UTF8));
        }
    }
}
