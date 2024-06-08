using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f1Race
{
    public class Lap
    {
        public int Minutes { get; set; }
        public int Second {  get; set; }

        public Lap(int min, int sec) {
            Minutes = min;
            Second = sec;
        }

        public override string ToString()
        {
            return string.Format($"{Minutes}:{Second}");
        }
    }
}
