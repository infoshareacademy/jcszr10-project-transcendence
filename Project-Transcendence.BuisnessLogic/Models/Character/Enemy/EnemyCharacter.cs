namespace Project_Transcendence.BuisnessLogic.Models.Character.Enemy
{
    using Project_Transcendence.BuisnessLogic.Models.Character;
    using Project_Transcendence.BuisnessLogic.Models.DTOs;
    using Project_Transcendence.BuisnessLogic.Models.Perks.Ability;
    using Project_Transcendence.BuisnessLogic.Models.Perks.Items;
    using System.Collections.Generic;

    public class EnemyCharacter : BasicCharacter, IEnemy, IDtoConvertible<EnemyDto>
    {
        public int Id { get; set; }
        public List<Ability> Abilities { get; set; }
        public List<IItem> ItemsToDrop { get; set; }

        public EnemyDto ConvertToDto() => new()
        {
            Id = Id,
            Abilities = Abilities,
            Inventory = ItemsToDrop,
            Name = Name,
            Race = Race,
            Level = Level,
            Health = Health.Health
        };
    }
}
