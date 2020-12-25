using System;
using System.Collections.Generic;
using System.Text;

namespace EHWR.Domain.DomainModel.Items
{
    public class ItemModel
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int ItemType { get; set; }
        public string ItemTypeName { get; set; }
        public string ItemDescription { get; set; }
        public int CustomerType { get; set; }
        public string CustomerTypeName { get; set; }
        public decimal Price_exTax { get; set; }
        public DateTime EffectiveDate { get; set; }
        public decimal TotalPrice { get; set; }
    }
    public class SearchItem: Search
    {
        public int ItemId { get; set; }
        public int StockType { get; set; }
        
    }
}
