using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f1Race
{
    public class Driver
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool isFirstDriver { get; set; }
        public List<Lap> laps { get; set; }

        public Driver(string name, int age, bool first)
        {
            Name = name;
            Age = age;
            isFirstDriver = first;
            laps = new List<Lap>();
        }

        private string isRookie()
        {
            if (isFirstDriver) return "F";
            return "S";

        }
        public Lap bestLap()
        {
            Lap max = laps.First();
            foreach (Lap lap in laps)
                {
                    if (lap.Minutes <= max.Minutes)
                    {
                        if (lap.Second <= max.Second)
                        {
                            max = lap;
                        }
                    }
                }
                return max;
        }

        public override string ToString()
        {
            return string.Format($"{Name} ({Age}) - {isRookie()}");
        }
    }
}
