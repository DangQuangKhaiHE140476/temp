using System;
using System.Collections.Generic;

namespace QLHSC07.Model.ConsultantCommunity
{
    public class ExpiredFormDto
    {
        public int Id { get; set; }
        public string Title  { get; set; }
        public string PlanningName { get; set; }
        public long PlanningId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool IsExpired { get; set; }
        public int NumberResult { get; set; }
    }
}
