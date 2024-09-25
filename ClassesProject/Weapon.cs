using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesProject
{
      public class Weapon
    {
        
        public string Name { get;}

        public float MinDamage { get; private set; }

        public float MaxDamage { get; private set; }

        public Weapon( string name ) 
        {
            Name = name ;
        }
        public Weapon(string name, float minDamage,float maxDamage) : this(name)
        {
            Name = name;
            SetDamageParams(minDamage,maxDamage);
        }

        public float GetDamage() 
        { 
            return (MaxDamage + MinDamage) / 2 ; 
        }

        public void SetDamageParams( float minDamage, float maxDamage)
        {
            if (minDamage > maxDamage) 
            {
                Console.WriteLine("Данные введены некорректно ");
                var temp = minDamage;
                minDamage = maxDamage;
                maxDamage = temp;
            }

            if (minDamage < 1)
            {
                Console.WriteLine("Форсированная установка минимального значения ");
                minDamage = 1;
            }

            if (maxDamage > 1)
            {
                Console.WriteLine(" Максимальный урон ");
                maxDamage = 10;
            }

            MinDamage = minDamage; MaxDamage = maxDamage;
        }

    }
}
