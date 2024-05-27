using QLHSC07.Model.BaseModels;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace QLHSC07.Model.Document
{
    public class CreateDocument : BaseCreateDto
    {
        [Required]
        public string Name { get; set; }
        public int Ordinal { get; set; }
        public long ParentId { get; set; }
        public int TypeId { get; set; }
        public long PlanningId { get; set; }
    }
    public class CreateDocumentFile : BaseCreateDto
    {
        public int Ordinal { get; set; }
        public long ParentId { get; set; }
        public int TypeId { get; set; }
        public long PlanningId { get; set; }
    }
}
