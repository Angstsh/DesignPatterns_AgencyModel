using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Engine
{
    /// <summary>
    /// 玩家探索
    /// </summary>
    public class PlayerQuest
    {
        public Quest Details { get; set; }
        public bool IsCompleted { get; set; }

        public PlayerQuest(Quest details, bool isCompleted)
        {
            Details = details;
            IsCompleted = IsCompleted;
        }
    }
}
