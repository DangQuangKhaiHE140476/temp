﻿using QLHSC07.CORE.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QLHSC07.Entity.QLHSC07_Entities
{
    [Table(TableFieldNameHelper.QLHSC07.ProjectGroup, Schema = Constant.Schema.QLHSC07)]
    public class ProjectGroup : BaseFullAuditedEntity<long>
    {
        public ProjectGroup()
        {
            Projects = new HashSet<Project>();
        }
        [Column("name")]
        [StringLength(Constant.Maxlength.Name)]
        public string Name { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
    }
}