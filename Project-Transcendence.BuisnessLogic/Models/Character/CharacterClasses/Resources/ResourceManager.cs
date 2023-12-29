using System.Security.AccessControl;

namespace Project_Transcendence.BuisnessLogic.Models.Character.CharacterClasses.Resources
{
    public class ResourceManager
    {
        public ResourceType Resource { get; set; }
        public int Amount { get; set; }
        public string Name { get; set; }
        public int MaxAmount { get; set; }


        public void Decrease(int amount)
        {
            if (amount > Amount)
            {
                Amount = 0;
            }
            else
            {
                Amount -= amount;
            }
        }

        public void Increase(int amount)
        {
            if (amount + Amount > MaxAmount)
            {
                Amount = MaxAmount;
            }
            else
            {
                Amount += amount;
            }

        }

    }
}
