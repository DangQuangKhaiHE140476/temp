using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLHSC07.CORE.Settings
{
    public class ClientSettings
    {
        public MapDefault MapDefault { get; set; }
    }

    public class MapDefault
    {
        public long Id { get; set; }
    }
}
