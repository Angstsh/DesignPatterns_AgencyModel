using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Engine
{
    /// <summary>
    /// 生物
    /// </summary>
    public class LivingCreature
    {
        public int MaximumHitPoints { get; set; }
        public int CurrentHitPoints { get; set; }

        public LivingCreature(int maximumHitPoints, int currentHitPoints)
        {
            MaximumHitPoints = maximumHitPoints;
            CurrentHitPoints = currentHitPoints;
        }
    }
}
