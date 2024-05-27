using System.ComponentModel.DataAnnotations.Schema;

namespace QLHSC07.Model.Document
{
    public class NodePath
    {
        public long Id { set; get; }
        public string Name { set; get; }
        public long ParentId { set; get; }
        public string Path { set; get; }
    }
}
