using QLHSC07.CORE.Helper;
using QLHSC07.Entity.Administrative;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QLHSC07.Entity.QLHSC07_Entities
{
    [Table(TableFieldNameHelper.QLHSC07.ProjectHasCommune, Schema = Constant.Schema.QLHSC07)]

    public class ProjectHasCommune : BaseFullAuditedEntity<long>
    {
        [Column("project_id")]
        public long ProjectId { get; set; }
        [ForeignKey(nameof(ProjectId))]
        public Project Project { get; set; }

        [Column("commune_id")]
        public int CommuneId { get; set; }
        [ForeignKey(nameof(CommuneId))]
        public Commune Commune { get; set; }
    }
}
