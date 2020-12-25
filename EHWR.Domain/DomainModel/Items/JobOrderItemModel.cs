using System;
using System.Collections.Generic;
using System.Text;

namespace EHWR.Domain.DomainModel.Items
{
    public class JobOrderItemModel
    {
        public int JobOrderItemId { get; set; }
        public int JobOrderId { get; set; }
        public int ItemType { get; set; }
        public string ItemTypeName { get; set; }
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string JobItemDescription { get; set; }
        public Decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public Decimal TotalPrice { get; set; }
    }

    public class ItemSearch : Search
    {
        public int JobOrderItemId { get; set; }
        public int JobOrderId { get; set; }
    }
}
