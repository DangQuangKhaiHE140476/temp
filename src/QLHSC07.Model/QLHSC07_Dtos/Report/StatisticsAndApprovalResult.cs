using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.QLHSC07_Dtos.Report
{
    public class StatisticsAndApprovalResult
    {
        public string ProjectType { get; set; }
        public int? ApprovingConstructionSiteNr { get; set; }
        public int GivingCommentsNr { get; set; }
        public int ApprovalNewProjects { get; set; }
        public int ApprovalOldProjects { get; set; }
        public int AcceptanceNewProjects { get; set; }
        public int AcceptanceOldProjects { get; set; }
        public int PetitionsNr { get; set; }
    }
}
