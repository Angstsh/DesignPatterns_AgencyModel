using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Engine
{
    /// <summary>
    /// 随机数生成器类
    /// </summary>
    public class RandomNumberGenerator
    {
        private static Random _generator = new Random();

        public static int NumberBetween(int minimumValue, int maximumValue)
        {
            return _generator.Next(minimumValue,maximumValue+1);
        }
    }
}
