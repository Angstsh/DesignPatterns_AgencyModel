using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Engine
{
    /// <summary>
    /// 武器
    /// </summary>
    public class Weapon : Item
    {
        public int MaximumDamage { get; set; }
        public int MinimumDamage { get; set; }

        public Weapon(int id, string name, string namePlural, int maximumDamage, int minimumDamage) : base(id, name, namePlural)
        {
            MaximumDamage = maximumDamage;
            MinimumDamage = minimumDamage;
        }
    }
}
