using Project_Transcendence.BuisnessLogic.Character;
using Project_Transcendence.BuisnessLogic.Character.CharacterRaces;
using Project_Transcendence.BuisnessLogic.Perks.Ability;

namespace Project_Transcendence.BuisnessLogic.Character
{
    public abstract class BasicCharacter : IHealth, IBasicCharacter  
    {
        public string Name { get; set; }
        public ICharacterRace Race { get; set; }
        public int Health { get; set; }
        public int Level { get; set; }

        public void IncreaseHealth()
        {
            Health += 100;
        }

        public void TakeDamage(IAbility ability)
        {
            Health -= ability.Damage;
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
        }

        public void TakeHealth(IAbility ability)
        {
            Health += ability.Healing;
        }

        public void TakeHealth(int healing)
        {
            Health += healing;
        }   
    }
}
