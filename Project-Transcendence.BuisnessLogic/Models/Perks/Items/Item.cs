
namespace Project_Transcendence.BuisnessLogic.Models.Perks.Items
{
    public abstract class Item : IItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}


