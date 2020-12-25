using System;
using System.Collections.Generic;
using System.Text;

namespace EHWR.Domain.DomainModel.Items
{
    public class ItemPriceModel
    {
        public int ItemPriceId { get; set; }
        public int ItemId { get; set; }

        public string ItemName { get; set; }
        public Decimal Price_exTax { get; set; }
        public DateTime EffectiveDate { get; set; }

    }
    public class SearchItemPrice
    {
        public int ItemId { get; set; }
        public int PageNo { get; set; }
        public int PageSize { get; set; }
    }
}
