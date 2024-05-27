using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.QLHSC07_Dtos.RecordsResultProcessings
{
    public class ErrorImportDataDto
    {
        public string MaHoSo { set; get; }
        public string message { set; get; }
    }
    public class ResultErrorImportData
    {
        public List<ErrorImportDataDto> Errors { set; get; }
        public string resultFile { set; get; }
    }
}
