namespace Project_Transcendence.BuisnessLogic.Models.Character
{
    public class HealthManager
    {
        public int Health { get;set; }

        public int MaxHealth { get; set; }

        public HealthManager(int health = 100)
        {
            Health = health;
            MaxHealth = health;
        }

        public void IncreaseMaxHealth(int addHealth)
        {
            MaxHealth += addHealth;
        }

        public void IncreaseHealth(int addHealth)
        {

            if(Health + addHealth > MaxHealth)
            {
                Health = MaxHealth;
            }
            else
            {
                Health += addHealth;
            }
        }

        public void DecreaseHealth(int takeHealth)
        {
            Health -= takeHealth;
        }

        public int GetHealth()
        {
            return Health;
        }

        public int GetMaxHealth()
        {
            return MaxHealth;
        }
    }
}
