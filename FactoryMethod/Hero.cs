using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Hero
    {
        public string Name { get; set; }
        public int Health { get; set; } 
        public int Damage { get; set; }
        public int Protection { get; set; }
        public int Agility { get; set; }


        public Hero(string name, int health, int damage,
                    int protection,int agility)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("name");
            }

            if (health <= 0 || damage <= 0 || protection <= 0 || agility <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            Name = name;
            Health = health;
            Damage = damage;
            Protection = protection;
            Agility = agility;
        }
    }
}
