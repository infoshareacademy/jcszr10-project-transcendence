namespace Project_Transcendence.BuisnessLogic.Models.Character.CharacterImplementations
{
    public class HealthManager
    {
        public int Health { get; set; }

        public int MaxHealth { get; set; }



        public HealthManager(int health = 0, int maxHEalth = 0)
        {
            Health = health;
            MaxHealth = maxHEalth;
        }

        public void IncreaseMaxHealth(int addHealth)
        {
            MaxHealth += addHealth;
        }

        public bool IsDead()
        {
            if (Health <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void IncreaseHealth(int addHealth)
        {

            if (Health + addHealth > MaxHealth)
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
