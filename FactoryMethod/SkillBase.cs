using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class SkillBase : ISkill
    {
        public string Name { get; protected set; }
        public double CDTime { get; protected set; }
        public int ManaCost { get; protected set; }

        public string SkillOwner {get; protected set; }

        public SkillBase(string name, double cDTime, int manaCost, string skillOwner)
        {
            //TODO: Проверить входные аргументы

            Name = name;
            CDTime = cDTime;
            ManaCost = manaCost;
            SkillOwner = skillOwner;
        }

        public abstract void ApplySkill();        
    }
}
