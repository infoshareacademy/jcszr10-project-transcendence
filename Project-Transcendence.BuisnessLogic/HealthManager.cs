
namespace Project_Transcendence.BuisnessLogic
{
    public class HealthManager
    {

        public int Health { get; private set; }

        public HealthManager(int health)
        {
            Health = health;
        }

        public void IncreaseHealth(int addHealth)
        {
            Health += addHealth;
        }

        public void DecreaseHealth(int takeHealth)
        {
            Health -= takeHealth;
        }

        public int GetHealth()
        {
            return Health;
        }

    }
}
