using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EHWR.Domain.DomainModel.GlobalCode
{
    public class GlobalCodeModel
    {
            public int GlobalCodeId { get; set; }

            public int CategoryId { get; set; }

            public string CategoryName { get; set; }

            public string CodeName { get; set; }

            public string Description { get; set; }

            public int Active { get; set; }

        }
        public class GlobelCodeCategoriesModel
        {
            public int CategoryId { get; set; }
            public string CategoryName { get; set; }
            public string Description { get; set; }
            public bool IsActive { get; set; }
            public int TotalRows { get; set; }
        }
        public class GlobelSearchModel
        {
            [Required]
            public string CategoryName { get; set; }
            public int GlobalCodeId { get; set; }
        }
     
    }

