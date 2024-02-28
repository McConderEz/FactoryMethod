using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Skills
{
    public class MageSkill : SkillBase
    {
        private int _skillProtection;

        public MageSkill(string name, double cDTime, int manaCost, string skillOwner) : base(name, cDTime, manaCost, skillOwner)
        {
            //TODO: Добавить проверки
        }

        public override void ApplySkill()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{SkillOwner} применил {Name} и наложил на себя щит от любого урона на {_skillProtection} ед.!");
            Console.ResetColor();
        }
    }
}
