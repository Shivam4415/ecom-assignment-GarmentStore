﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document.Library.Globals.Enum
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Size
    {
        Small = 1,
        Medium = 2,
        Large = 3
    }
}
