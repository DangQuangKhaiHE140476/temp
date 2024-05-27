using System.Collections.Generic;
using System.Reflection;
using QLHSC07.Infrastructure.Interface;

namespace QLHSC07.Model.ConsultantCommunity
{
    public class DetailFeedbackDto
    {
        public int FormTemplateId { get; set; }
        public List<Question> Questions { get; set; }
        public IPagedList<UserAnswer> UserAnswers { get; set; }
    }

    public class UserAnswer
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Suggestion { get; set; }
        public string Reply { set; get; }
        public string CreatedDate { set; get; }
        public List<PersonAnswer> Answers { get; set; }
    }

    public class PersonAnswer
    {
        public int QuestionId { get; set; }
        public int? AnswerId { get; set; }
        public string Additions { get; set; }
    }

}
