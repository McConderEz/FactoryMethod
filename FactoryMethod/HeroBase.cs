using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class HeroBase : IHero
    {
        public string Name { get; protected set; }
        public int Health { get; protected set; }
        public int Damage { get; protected set; }
        public int Protection { get; protected set; }
        public int Agility { get; protected set; }

        public HeroBase(string name, int health, int damage, int protection, int agility)
        {
            //TODO: Проверить входные данные
            Name = name;
            Health = health;
            Damage = damage;
            Protection = protection;
            Agility = agility;
        }

        public abstract void Attack();
        public abstract void Move();
        public abstract void PickUp();

        public abstract ISkill CreateSkill(string skillName, double cdTime, int manaCost); 

    }
}
