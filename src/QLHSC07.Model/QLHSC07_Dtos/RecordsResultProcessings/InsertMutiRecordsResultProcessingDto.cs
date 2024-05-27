using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.QLHSC07_Dtos.RecordsResultProcessings
{
    public class InsertMutiRecordsResultProcessingDto
    {
       public string pC07LocalId { get; set; }
        public IFormFile pdfZip { set; get; }
         public IFormFile excel { set; get; }
    }
}
