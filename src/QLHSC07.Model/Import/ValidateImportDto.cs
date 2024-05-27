using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.Import
{
    public class ValidateImportDto
    {
        public ImportRecordsDto Record { get; set; }
        public bool IsValid { get; set; }
        public List<HistoryImportDetailDto> FailedObjs { get; set; }
    }
    public class HistoryImportDetailDto
    {
        public string FileName { get; set; }
        public string SheetName { get; set; }
        public string Row { get; set; }
        public string RawData { get; set; }
        public string Description { get; set; }
    }
}
