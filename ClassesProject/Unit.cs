﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ClassesProject
{
    public class Unit
    {
        private float _health;
        private float _armor;
        private float _helm;
        private float _damage;

        public string Name { get; }
        public float Health => _health;



        public Unit() : this("Unknown Unit", 10)
        {
        }
        public Unit(string name, float health)
        {
            Name = name;
            _health = health;
        }
        public float RealHealth()
        {
            return Health * (1 + Armor);
        }
        public float Armor
        {
            get { return (float)Math.Round(_armor, 2); }
            set
            {
                if (value >= 0 || value <= 1)
                {
                    _armor = value;
                }
                else { }
            }
        }
        public bool SetDamage(float value)
        {
            _health = _health - value * _armor;
            if (_health < 0)
            {
            }

            public void EquipHelm(Helm helm) { _helm = helm; }
        }

    }
}