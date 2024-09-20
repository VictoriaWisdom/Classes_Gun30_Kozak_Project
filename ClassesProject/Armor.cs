using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesProject
{
    public class Helm
    {
        public string Name { get; }
        public float Armor { get; set; }

        public Helm(string name = "Helm")
        {
            Name = name;
        }
        public Helm(float armor, string name = "Helm") : this(name)
        {
            Armor = armor;
        }
    }
    public class Shell
    {
    }
    public class Boots
    {
    }
}
