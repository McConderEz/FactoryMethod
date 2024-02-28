using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Skills
{
    /// <summary>
    /// Реализация навыка Воина
    /// </summary>
    public class WarriorSkill : SkillBase
    {
        private int _skillDamage = 10;

        public WarriorSkill(string name, double cDTime, int manaCost, string skillOwner) : base(name, cDTime, manaCost, skillOwner)
        {
            //TODO: Добавить проверки
        }

        public override void ApplySkill()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{SkillOwner} применил {Name} и нанёс {_skillDamage} урона!");
            Console.ResetColor();
        }
    }
}
