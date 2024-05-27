using QLHSC07.CORE.Helper;
using QLHSC07.Entity.Administrative;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QLHSC07.Entity.QLHSC07_Entities
{
    [Table(TableFieldNameHelper.QLHSC07.Project, Schema = Constant.Schema.QLHSC07)]

    public class Project : BaseFullAuditedEntity<long>
    {
        [Column("name")]
        public string Name { get; set; }
        [Column("investor_id")]
        public long InvestorId { get; set; }
        [ForeignKey(nameof(InvestorId))]
        public Investor Investors { get; set; }

        [Column("project_type_id")]
        public long ProjectTypeId { get; set; }
        [ForeignKey(nameof(ProjectTypeId))]
        public ProjectType ProjectType { get; set; }

        [Column("project_group_id")]
        public long ProjectGroupId { get; set; }
        [ForeignKey(nameof(ProjectGroupId))]
        public ProjectGroup ProjectGroup { get; set; }

        [Column("address")]
        public string Address { get; set; }

        [Column("building_site")]
        public string BuildingSite { get; set; }
        
        [Column("is_edit")]
        public bool IsEdit { get; set; }

        [Column("project_status_id")]
        public long? ProjectStatusId { get; set; }
        [ForeignKey(nameof(ProjectStatusId))]
        public ProjectStatus ProjectStatus { get; set; }

        [Column("note")]
        public string Note { get; set; }
              
        //[Column("construction_type_id")]
        //public long ConstructionTypeId { get; set; }
        //[ForeignKey(nameof(ConstructionTypeId))]
        //public ConstructionType ConstructionTypes { get; set; }
        public virtual ICollection<Records> Records { get; set; }
        public virtual ICollection<ProjectHasCommune> ProjectHasCommunes { get; set; }
    }
}
