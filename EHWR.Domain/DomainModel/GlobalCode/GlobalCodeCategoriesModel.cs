using System;
using System.Collections.Generic;
using System.Text;

namespace EHWR.Domain.DomainModel.GlobalCode
{
    public class GlobalCodeCategoriesModel
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string GlobalCodeCategoryDescription { get; set; }
        public int GlobalCodeId { get; set; }
        public string CodeName { get; set; }
        public string GlobalCodeDescription { get; set; }
       
    }
}
