using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace QLHSC07.CORE.Enum
{
    public enum RecordPermissionEnum
    {
        [Description("SeeOnlyMineRecord")]
        SeeOnlyMineRecord = 1,
        [Description("SeeAllRecord")]
        SeeAllRecord = 2
    }
}
