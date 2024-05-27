using QLHSC07.Model.BaseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.QLHSC07_Dtos.RecordTypes
{
    public class CreateRecordTypesDto : BaseCreateDto
    {
        public string Name { get; set; }
        public bool? IsApproval { get; set; }
        public string Waiting_Type { get; set; } //giờ: h, ngày: d
        public int WaitingTime { get; set; }
    }
}
