using Project_Transcendence.BuisnessLogic.Perks.Ability;

namespace Project_Transcendence.BuisnessLogic.Character
{
    public interface IHealth
    {
        public void TakeDamage(IAbility ability);
        public void TakeDamage(int damage);
        public void TakeHealth(IAbility ability);
        public void TakeHealth(int healing);

    }
}
