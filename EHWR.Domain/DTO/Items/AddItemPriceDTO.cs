using System;
using System.Collections.Generic;
using System.Text;

namespace EHWR.Domain.DTO.Items
{
    public class AddItemPriceDTO
    {
        public int ItemId { get; set; }
        public Decimal Price_exTax { get; set; }
        public DateTime EffectiveDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
