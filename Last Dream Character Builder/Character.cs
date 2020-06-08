using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_Dream_Character_Builder
{
    abstract class Character
    {
        // fields for attributes all characters (player or enemy) have
        protected int _maxHP, _currentHP, _maxMP, _currentMP, 
            _attack, _defense, _intelligence, _agility, 
            _accuracy, _critical, _preemption, _magicDefense;

        // Constructor - covers attributes
        protected Character(int startingHP, int startingMP, 
            int startingAttack, int startingDefense, int startingIntelligence, int startingAgility, 
            int startingAccuracy, int startingCritical, int startingPreemption, int startingMagicDefense)
        {
            _maxHP = startingHP;
            _currentHP = _maxHP;
            _maxMP = startingMP;
            _currentMP = _maxMP;
            _attack = startingAttack;
            _defense = startingDefense;
            _intelligence = startingIntelligence;
            _agility = startingAgility;
            _accuracy = startingAccuracy;
            _critical = startingCritical;
            _preemption = startingPreemption;
            _magicDefense = startingMagicDefense;
        }
        // properties for stats (stats can only be incremented/decremented, not directly set)
        public virtual int MaxHP { get => _maxHP; }
        public virtual int CurrentHP { get => _currentHP; set => _currentHP = value;  }
        public virtual int MaxMP { get => _maxMP; }
        public virtual int CurrentMP { get => _currentMP; set => _currentMP = value; }
        public virtual int Attack { get => _attack; }
        public virtual int Defense { get => _defense; }
        public virtual int Intelligence { get => _intelligence; }
        public virtual int Agility { get => _agility; }
        public virtual int Accuracy { get => _accuracy; }
        public virtual int Critical { get => _critical; }
        public virtual int Preemption { get => _preemption; }
        public virtual int MagicDefense { get => _magicDefense; }

        // Performs a basic attack command
        public virtual void BasicAttack(Character target, double damageModifier = 1)
        {
            target.CurrentHP -= (int)(CalculatePhysicalDamage(this.Attack, target.Defense) * damageModifier);
        }

        // Calculates physical damage (from basic attack or offensive skill) based on the user's attack and the target's defense
        public int CalculatePhysicalDamage(int attackUser, int defenseTarget)
        {
            int damage; // calculated physical damage

            // ----- Add random number generator for +-20% damage

            damage = (4 * attackUser) - (2 * defenseTarget);

            if (damage < 1) { damage = 1; }

            return damage;
        }

        // 
    }
}
