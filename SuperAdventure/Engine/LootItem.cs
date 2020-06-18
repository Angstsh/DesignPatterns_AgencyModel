using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Engine
{
    /// <summary>
    /// 抢劫物品
    /// </summary>
    public class LootItem
    {
        public Item Details { get; set; }
        public int DropPercentage { get; set; } //掉落几率
        public bool IsDefaultItem { get; set; } //是否默认物品

        public LootItem(Item details, int dropPercentage, bool isDefaultItem)
        {
            Details = details;
            DropPercentage = dropPercentage;
            IsDefaultItem = isDefaultItem;
        }
    }
}
