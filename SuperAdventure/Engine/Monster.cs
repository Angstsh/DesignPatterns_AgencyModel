using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Engine
{
    /// <summary>
    /// 怪物
    /// </summary>
    public class Monster : LivingCreature
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaximumDamage { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }
        public List<LootItem> LootTable { get; set; }

        public Monster(int id, string name, int maximumDamage, int rewardExperiencePoints, int rewardgold, int maximumHitPoints, int currentHitPoints) : base(maximumHitPoints, currentHitPoints)
        {
            ID = id;
            Name = name;
            MaximumDamage = maximumDamage;
            RewardExperiencePoints = rewardExperiencePoints;
            RewardGold = rewardgold;

            LootTable = new List<LootItem>();
        }
    }
}
