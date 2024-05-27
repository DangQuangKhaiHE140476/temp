using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.QLHSC07_Dtos.Records
{
    public class UpdateStatusRecordsDto
    {
        public long Id { get; set; }
        public long StatusId { get; set; }
        public string CancelReason { get; set; }  //Nếu statusId=4, thì có thêm field này
        public DateTime? DateRealReturn { get; set; } //Nếu StatusId=3,4, thì có thêm field này
        public bool? Result { get; set; } //nếu StatusId=3 thì có thêm field này
    }
}
