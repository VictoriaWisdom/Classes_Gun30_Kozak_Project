using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesProject
{
    public class Armoer
    {
        public class Helm
        {
            string name = "Helm";
            float armor = 0f;
            public string Name { get; }
            public float Armor
            {
                get => armor;
                set
                {
                    armor = value;
                    if (armor < 0)
                    {
                        armor = 0;
                    }
                    else if (armor > 1)
                    {
                        armor = 1;
                    }
                }
            }


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
            string name = "Shell";
            float armor = 0f;
            public string Name { get; }
            public float Armor
            {
                get => armor;
                set
                {
                    armor = value;
                    if (armor < 0)
                    {
                        armor = 0;
                    }
                    else if (armor > 1)
                    {
                        armor = 1;
                    }
                }
            }
            public Shell(string name = "Shell")
            {
                Name = name;
            }
            public Shell(float armor, string name = "Shell") : this(name)
            {
                Armor = armor;
            }


        }
        public class Boots
        {
            string name = "Boots";
            float armor = 0f;
            public string Name { get; }
            public float Armor
            {
                get => armor;
                set
                {
                    armor = value;
                    if (armor < 0)
                    {
                        armor = 0;
                    }
                    else if (armor > 1)
                    {
                        armor = 1;
                    }
                }
            }
            public Boots(string name = "Boots")
            {
                Name = name;
            }
            public Boots(float armor, string name = "Bootsl") : this(name)
            {
                Armor = armor;
            }
        }
    }
}

