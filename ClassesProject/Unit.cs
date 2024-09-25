using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ClassesProject
{
    public class Unit
    {
        private string name;
        private float _health;
        private float realHealth;

        private Helm _helm;
        private Shell _shell;
        private Boots _boots;
        private Weapon _weapon;
        
        public string Name { get; }
        public float Health => _health;
        
        public float Damage
        {
            get
            {
                if (_weapon == null)
                {
                    return 5;
                }
                return _weapon.GetDamage() +5 ;

            }
        }

        public Unit ()
        {
            this.name = "Unknown Unit";
        }
        public Unit(string name) : this (name, 10f, )
        {
        }
        public Unit (string name, float health, float value)
        {
            this.name = name;
            this. _health = health;
            this._armor = value;
        }
        public float RealHealth()
        {
            return Health * (1 + Armor);
        }
        public float Armor
        {
            get 
            {
                var armor =_helm.Armor + _boots.Armor + _shell.Armor;
                if (armor < 0)
                {
                    armor = 0;
                }
               else if ( armor > 1 ) 
                {
                    armor = 1f;
                }
                return (float)Math.Round(armor, 2);
            }
            
        }
        public bool SetDamage (float value)
        {
            _health = _health - value * Armor;
            return _health <= 0;
        }
        public void EquiqWeapon(Weapon weapon) { _weapon = weapon; }
        public void EquipHelm(Helm helm) { _helm = helm; }
        public void EquipShell(Shell shell) { _shell = shell; }
        public void EquipBoots(Boots boots) { _boots = boots; }

    } 
       
}
