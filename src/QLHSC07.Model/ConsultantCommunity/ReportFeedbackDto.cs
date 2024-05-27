using System.Collections.Generic;
using System.Reflection;

namespace QLHSC07.Model.ConsultantCommunity
{
    public class ReportFeedbackDto
    {
        public int FormTemplateId { get; set; }
        public List<QuestionReport> Questions { get; set; }
    }

    public class QuestionReport
    {
        public string Title { get; set; }
        public List<AnswerReport> Answers { get; set; }
        public List<string> Additions { get; set; }
    }

    public class AnswerReport
    {
        public string Title { get; set; }
        public int Count { get; set; }
    }


}
