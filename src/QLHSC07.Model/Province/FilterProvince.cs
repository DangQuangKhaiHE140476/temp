using System;

namespace QLHSC07.Model.Province
{
    public class FilterProvince
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public string SortExpression { get; set; }
        public string Name { get; set; }
        public int? OrderNumber { get; set; }
        public bool? IsDelete { get; set; }
    }
}
