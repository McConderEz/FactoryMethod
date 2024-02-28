using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Skills
{
    public class ThiefSkill : SkillBase
    {
        private int _skillInvincible = 50;

        public ThiefSkill(string name, double cDTime, int manaCost, string skillOwner) : base(name, cDTime, manaCost, skillOwner)
        {
            //TODO: Добавить проверки
        }

        public override void ApplySkill()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{SkillOwner} применил {Name} и наложил на щанс уворота {_skillInvincible} %!");
            Console.ResetColor();
        }
    }
}
