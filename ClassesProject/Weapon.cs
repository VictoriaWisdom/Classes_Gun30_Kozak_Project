using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesProject
{
      public class Weapon
    {
        private float _damage;
        public string Name { get;}

        public float MinDamage { get; private set; }

        public float MaxDamage { get; private set; }

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

            MinDamage = minDamage; MaxDamage = maxDamage;
        }

    }
}
