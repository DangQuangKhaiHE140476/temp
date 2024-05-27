using QLHSC07.Model.BaseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.CRM.Client
{
    public class CreateClientDto : BaseCreateDto
    {
        public string Name { set; get; }
        public string Email { set; get; }
        public string PhoneNumber { set; get; }
        public double TotalMoney { set; get; }
        public string UserId { get; set; }
        public string EmployeeName { get; set; }

        public int[] ProvinceIds { set; get; } //list province Id
        public string Description { set; get; }
        public bool IsActive { set; get; }
        public bool IsConfirm { set; get; }
        public int[] ClientType { set; get; }
        public string UserName { set; get; }
        public string Password { set; get; }
    }
}
