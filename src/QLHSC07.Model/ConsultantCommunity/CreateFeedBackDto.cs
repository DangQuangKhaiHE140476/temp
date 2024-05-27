using System.Collections.Generic;

namespace QLHSC07.Model.ConsultantCommunity
{
    public class CreateFeedBackDto
    {
        public int FormTemplateId { get; set; }
        public string Name { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Suggestion { get; set; }
        public List<AnswerDetail> Answers { get; set; }
    }

    public class AnswerDetail
    {
        public int QuestionId { get; set; }
        public int? AnswerId { get; set; }
        public string Addition { get; set; }
    }
}
