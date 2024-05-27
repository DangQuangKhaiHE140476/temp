using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace QLHSC07.CORE.Enum
{
    public enum ModifyEnum
    {
        [Description("INSERT")]
        INSERT = 0,
        [Description("UPDATE")]
        UPDATE = 1,
        [Description("DELETE")]
        DELETE = 2,
        [Description("DELETEPERMANENT")]
        DELETEPERMANENT = 3
    }
}
