using FactoryMethod.Skills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Heroes
{
    public class ThiefHero : HeroBase
    {
        public ThiefHero(string name, int health, int damage, int protection, int agility)
             : base(name, health, damage, protection, agility)
        {

        }

        public override void Attack()
        {
            Console.WriteLine($"{Name} совершил атаку и нанёс {Damage} урона!");
        }

        public override ISkill CreateSkill(string skillName, double cdTime, int manaCost)
        {
            var skill = new ThiefSkill(skillName, cdTime, manaCost, Name);
            return skill;
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} передвигается со скоростью {Agility * 2.5}!");
        }

        public override void PickUp()
        {
            Console.WriteLine($"{Name} поднял предмет!");
        }
    }
}
