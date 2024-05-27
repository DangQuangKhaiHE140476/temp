using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.Import
{
    public class ImportRecordsDto
    {
        /// <summary>
        /// Số dòng trong file
        /// </summary>
        public string RowNumber { get; set; }

        /// <summary>
        /// Số dòng thực tế
        /// </summary>
        public string RowReal { get; set; }

        /// <summary>
        /// Tên công trình
        /// </summary>
        public string ProjectName { get; set; }

        /// <summary>
        /// Địa chỉ cụ thể
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        ///Tỉnh, TP
        /// </summary>
        public string Province { get; set; }
        /// <summary>
        /// Chủ đầu tư
        /// </summary>
        public string InvestorName { get; set; }
        /// <summary>
        ///Quy mô công trình
        /// </summary>
        public string ScaleProject { get; set; }
        /// <summary>
        /// Phân loại công trình
        /// </summary>
        public string ProjectType { get; set; }
        /// <summary>
        /// Phân nhóm dự án
        /// </summary>
        public string ProjectGroup { get; set; }
        /// <summary>
        /// Phân cấp công trình
        /// </summary>
        public string ProjectLevel { get; set; }
        /// <summary>
        /// Số Văn bản thẩm duyệt			
        /// </summary>
        public string TextNumberTD { get; set; }
        /// <summary>
        /// Thời gian văn bản thẩm duyệt	
        /// </summary>
        public string TextTimeTD { get; set; }
        /// <summary>
        /// Chú thích loại văn bản thẩm duyệt	
        /// </summary>
        public string TextTypeDescriptionTD { get; set; }

        /// <summary>
        /// Số Văn bản thẩm duyệt			
        /// </summary>
        public string TextNumberNT { get; set; }
        /// <summary>
        /// Thời gian văn bản thẩm duyệt	
        /// </summary>
        public string TextTimeNT { get; set; }
        /// <summary>
        /// Chú thích loại văn bản thẩm duyệt	
        /// </summary>
        public string TextTypeDescriptionNT { get; set; }
        /// <summary>
        /// Ghi chú
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Cán bộ
        /// </summary>
        public string UserAccept { get; set; }

        ///ProvinceId
        public int? ProvinceId { get; set; }

        ///GroupProjectId
        public long GroupProjectId { get; set; }
        ///CommuneId
        public int CommuneId { get; set; }
        ///DistrictId
        public int? DistrictId { get; set; }
        
        ///ProjectId
        public long ProjectId { get; set; }
        
        ///InvestorId
        public long InvestorId { get; set; }
        public string GetRawData()
        {
            string[] stringBuilder = new string[] {RowNumber, ProjectName, Address, Province, InvestorName, ScaleProject, ProjectType, ProjectGroup, ProjectLevel, TextNumberTD, TextTimeTD?.ToString(), TextTypeDescriptionTD, TextNumberNT, TextTimeNT?.ToString(), TextTypeDescriptionNT, Description, UserAccept };
            return string.Join(", ", stringBuilder);
        }
    }
}
