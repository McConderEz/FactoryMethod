using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    /// <summary>
    /// Базовый интерфейс, который должен реализовывать любой тип Героя
    /// </summary>
    public interface IHero
    {
        public string Name { get; }
        public int Health { get; }
        public int Damage { get; }
        public int Protection { get; }
        public int Agility { get; }

        void Attack();
        void Move();
        void PickUp();

        ISkill CreateSkill(string  skillName, double cdTime, int manaCost);
    }
}
