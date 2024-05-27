using QLHSC07.Entity.CRM;
using QLHSC07.Model.CRM.Plan;
using QLHSC07.Services.BaseServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Services.Interfaces.CRM
{
    public interface IPlanService : IBaseService<long, Plan, PlanViewDto, PlanViewDto, CreatePlanDto, UpdatePlanDto, FilterPlanDto>
    {
    }
}
