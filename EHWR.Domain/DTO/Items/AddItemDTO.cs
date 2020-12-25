using System;
using System.Collections.Generic;
using System.Text;

namespace EHWR.Domain.DTO.Items
{
    public class AddItemDTO
    {
        public int ItemType { get; set; }
        public int CustomerType { get; set; }
        public int AccountId { get; set; }
        public int SupplierId { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public Decimal Price_exTax { get; set; }
        public DateTime EffectiveDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
