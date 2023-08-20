namespace Project_Transcendence.BuisnessLogic.Models.Perks.Items
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
