using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.BaseModels
{
    public class FullAuditedEntityDto<T> : EntityDto<T>, IFullAuditedEntityDto<T>
    {
        [JsonProperty("created_by")]
        public string CreatedBy { get ; set ; }
        [JsonPropertyAttribute("created_date")]
        public DateTime CreatedDate { get ; set ; }
        [JsonPropertyAttribute("modified_by")]
        public string ModifiedBy { get ; set ; }
        [JsonPropertyAttribute("modified_date")]
        public DateTime ModifiedDate { get ; set ; }
        public bool IsDelete { get; set; }
    }
}
