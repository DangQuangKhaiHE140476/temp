using System.Collections.Generic;

namespace QLHSC07.Model.ConsultantCommunity
{
    public class FormTemplateDto
    {
        public int? Id { get; set; } //int?
        public int? ConsultantCommunityId { get; set; }
        public string Title { get; set; }
        public List<Question> Questions { get; set; }
    }

    public class Question
    {
        public int? Id { get; set; }
        public string Title { get; set; }
        public int Order { get; set; }
        public bool HaveAdditional { get; set; }
        public string AnswerType { get; set; }
        public List<Answer> Answers { get; set; }

    }

    public class Answer
    {
        public int? Id { get; set; }
        public string Title { get; set; }
        public int Order { get; set; }
    }
}
