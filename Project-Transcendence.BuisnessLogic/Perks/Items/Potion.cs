
namespace Project_Transcendence.BuisnessLogic.Perks.Items
{
    public class Potion : IPotion
    {
        public int Healing { get; set; }

        public Potion(int healing)
        {
            Healing = healing;
        }

    }
}
