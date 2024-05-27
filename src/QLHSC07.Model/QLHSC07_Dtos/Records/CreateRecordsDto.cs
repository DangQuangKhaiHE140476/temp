using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QLHSC07.Model.BaseModels;
using QLHSC07.Model.QLHSC07_Dtos.Projects;
using QLHSC07.Model.QLHSC07_Dtos.RecordsFiles;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.QLHSC07_Dtos.Records
{
    public class CreateRecordsDto : BaseCreateDto
    {
        public long? RecordsTypeId { get; set; }
        public CreateProjectDto Project { get; set; }
        /// <summary>
        /// Number of votes received
        /// </summary>
        public string RecordNum { get; set; }
        /// <summary>
        /// Reception form
        /// </summary>
        public long? ReceiveTypeId { get; set; }

        public DateTime? ReceiveDate { get; set; }

        public string ReceiveUserName { get; set; }

        public long? PC07ReceiveId { get; set; }

        public long? PC07ManageId { get; set; }

        ///Number of reply texts
        public DateTime? DatePredictReturn { get; set; }

        public DateTime? DateRealReturn { get; set; }
        public DateTime? DatePredictCheck { get; set; }

        public bool? Result { get; set; }

        public string ReturnDocNumb { get; set; }
        public long? DocumentAnsTypeId { get; set; }

        public long? RecordsStatusId { get; set; }
        public string CancelReason { get; set; }

        public List<FileAttachmentDto> RecordFile { get; set; }
    }
}
