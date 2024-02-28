using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public interface ISkill
    {
        string Name { get; }
        string SkillOwner { get; }
        double CDTime { get; } 
        int ManaCost { get; }

        void ApplySkill();
    }
}
