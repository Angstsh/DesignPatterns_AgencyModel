using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Engine
{
    /// <summary>
    /// 治愈药水
    /// </summary>
    public class HealingPotion : Item
    {
        public int AmountToHeal { get; set; }

        //派生类中创建构造函数
        public HealingPotion(int id, string name, string namePlural, int amountToHeal) : base(id, name, namePlural)
        {
            AmountToHeal = amountToHeal;
        }
    }
}
