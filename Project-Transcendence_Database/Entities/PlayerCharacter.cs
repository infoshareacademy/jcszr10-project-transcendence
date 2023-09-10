using Project_Transcendence.BuisnessLogic.Models.Perks.Items;

namespace Project_Transcendence_Database.Entities
{
    public class PlayerCharacter
    {
        public int Id { get; set; }

        public int CharacterClassId { get; set; }
        public virtual CharacterClass CharacterClass { get; set; }

        public int CharacterRaceId { get; set; }
        public virtual CharacterRace CharacterRace { get; set; }


        public virtual Inventory Inventory { get; set; }



        public virtual ICollection<Jewelery> Jewelery { get; set; }



        public virtual Weapon MainHandWeapon { get; set; }



        public virtual Weapon OffHandWeapon { get; set; }


        public string Name { get; set; }
        public int Level { get; set; }
        public int Intelect { get; set; }
        public int Agility { get; set; }
        public int Strength { get; set; }
        public int Luck { get; set; }
        public int Expirience { get; set; }
        public int FinishedDungeonIndex { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }

    }
}
