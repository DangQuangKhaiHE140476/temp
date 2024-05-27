using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace QLHSC07.CORE.Enum
{
    public enum PermissionAccessEnum
    {
        [Description("ALLOW")]
        ALLOW = 0,
        [Description("DENIED")]
        DENIED = 1,
        [Description("UNKNOWN")]
        UNKNOWN = 2
    }
}
