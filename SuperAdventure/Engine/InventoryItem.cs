using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Engine
{
    /// <summary>
    /// 库存物品
    /// </summary>
    public class InventoryItem
    {
        public Item Details { get; set; }
        public int Quantity { get; set; }   //数量

        public InventoryItem(Item details, int quantity)
        {
            Details = details;
            Quantity = quantity;
        }
    }
}
