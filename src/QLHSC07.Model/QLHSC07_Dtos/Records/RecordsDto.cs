using QLHSC07.Model.BaseModels;
using QLHSC07.Model.QLHSC07_Dtos.Projects;
using QLHSC07.Model.QLHSC07_Dtos.RecordsFiles;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace QLHSC07.Model.QLHSC07_Dtos.Records
{
    public class RecordsDto: FullAuditedEntityDto<long>
    {
        public long? ProjectId { get; set; }
        public string ProjectsName { get; set; }
        public long ProjectsInvestorId { get; set; }
        public string ProjectsInvestorName { get; set; }
        public long ProjectsProjectTypeId { get; set; }
        public string ProjectsProjectTypeName { get; set; }
        public long ProjectsProjectGroupId { get; set; }
        public string ProjectsProjectGroupName { get; set; }
        public string ProjectsAddress { get; set; }
        public List<Positions> Positions { get; set; }
        public List<int> ProjectCommuneIds { get; set; }
        public string ProjectsBuildingSite { get; set; }
        public string ProjectsIsEdit { get; set; }
        public long ProjectsProjectStatusId { get; set; }
        public string ProjectsProjectStatusName { get; set; }
        public string ProjectsNote { get; set; }
        public long? RecordsTypeId { get; set; }
        public string RecordsTypeName { get; set; }

        public string RecordNum { get; set; }

        public long? ReceiveTypeId { get; set; }
        public string ReceiveTypeName { get; set; }

        public DateTime? ReceiveDate { get; set; }

        public string ReceiveUserName { get; set; }

        public long? PC07ReceiveId { get; set; }
        public string PC07ReceiveName { get; set; }

        public long? PC07ManageId { get; set; }
        public string PC07ManageName { get; set; }
        public long? PC07ManageProvinceId { get; set; }

        public DateTime? DatePredictReturn { get; set; }
        public long? DocumentTypeId { get; set; }
        public string DocumentType { get; set; }

        public DateTime? DateRealReturn { get; set; }
        public DateTime? DatePredictCheck { get; set; }
        public bool? Result { get; set; }
        public string ReturnDocNumb { get; set; }
        public long? RecordsStatusId { get; set; }
        public string RecordsStatuName { get; set; }
        public long? DocumentAnsTypeId { get; set; }
        public string DocumentAnsTypeName { get; set; }
        public string CancelReason { get; set; }

        public List<RecordsFileDto> RecordsFiles { get; set; }
    }
}
