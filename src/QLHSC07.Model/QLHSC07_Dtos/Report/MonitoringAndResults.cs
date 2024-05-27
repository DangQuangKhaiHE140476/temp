using QLHSC07.Model.QLHSC07_Dtos.Projects;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.QLHSC07_Dtos.Report
{
    public class MonitoringAndResults
    {
        public string NumberOfVotesReceived { get; set; }
        public string ProjectName { get; set; }
        public string InvestorName { get; set; }
        public string BuildingSite { get; set; }
        public string RecordType { get; set; }
        public string ReceptionForm { get; set; }
        public DateTime? ReceptionTime { get; set; }
        public string ReceptionOfficer { get; set; }
        public DateTime? AppointmentResult { get; set; }
        public string NumberOfReplyTexts { get; set; }
        public DateTime? ReplyTextDate { get; set; }
        public DateTime? ResultsDay { get; set; }
        public string ResultRecipient { get; set; }
        public string Address { get; set; }
        public string PositionsJsonString { get; set; }
        public List<Positions> Positions { get; set; }
        public long? ProjectTypeId { get; set; }
        public string ProjectTypeName { get; set; }
        public long? RecordTypeId { get; set; }
        public bool? IsNewProject { get; set; }
    }
}
