using System;
using System.Collections.Generic;
using System.Text;

namespace EHWR.Domain.DomainModel
{
    public class Search    {
        public int PageNo { get; set; }
        public int PageSize { get; set; }
        public string SearchValue { get; set; }
        public string SortColumn { get; set; }
        public string SortOrder { get; set; }
    }
}
