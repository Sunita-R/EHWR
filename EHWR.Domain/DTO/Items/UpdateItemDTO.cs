using System;
using System.Collections.Generic;
using System.Text;

namespace EHWR.Domain.DTO.Items
{
    public class UpdateItemDTO
    {
        public int ItemId { get; set; }
        public int ItemType { get; set; }
        public int CustomerType { get; set; }
        public int AccountId { get; set; }
        public int SupplierId { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public string ModifiedBy { get; set; }
    }
}
