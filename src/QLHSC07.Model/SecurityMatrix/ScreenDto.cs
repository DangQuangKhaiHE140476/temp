using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.SecurityMatrix
{
    public class ScreenDto
    {
        public int Id { set; get; }
        public int? ParentId { set; get; }
        [JsonIgnore]
        public ScreenDto Parent { get; set; }

        public string Code { set; get; }
        public string Name { set; get; }
        public string Title { set; get; }
        public string Icon { set; get; }
        public int Order { get; set; }
        public ICollection<ScreenDto> Childrent { get; set; }
    }
}
