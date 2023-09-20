namespace Project_Transcendence.BuisnessLogic.Models.Character.Enemy
{
    using Project_Transcendence.BuisnessLogic.Models.Character;
    using Project_Transcendence.BuisnessLogic.Models.Perks.Ability;
    using Project_Transcendence.BuisnessLogic.Models.Perks.Items;
    using System.Collections.Generic;

    public class Enemy : BasicCharacter, IEnemy
    {
        public int Id { get; set; }
        public ICollection<Ability> Abilities { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public virtual ICollection<Item> ItemsToDrop { get; set; }

    }
}
