using QLHSC07.CORE.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QLHSC07.Entity.QLHSC07_Entities
{
    [Table(TableFieldNameHelper.QLHSC07.HistoryImportLog, Schema = Constant.Schema.QLHSC07)]
    public class HistoryImportLog : BaseFullAuditedEntity<long>
    {
        public string FileName { get; set; }
        public string SheetName { get; set; }
        public string Row { get; set; }
        public string RawData { get; set; }
        public string Description { get; set; }
    }
}
