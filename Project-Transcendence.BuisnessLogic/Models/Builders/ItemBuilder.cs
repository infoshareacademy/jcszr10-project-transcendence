
using Project_Transcendence.BuisnessLogic.Models.DTOs;
using Project_Transcendence.BuisnessLogic.Models.Perks.Items;

namespace Project_Transcendence.BuisnessLogic.Models.Builders
{
    public class ItemBuilder : IItemBuilder
    {
        private readonly ItemDto _itemDto;
        private readonly Item _item;



        public Item Build()
        {
            return _item;
        }

        public void SetArmor()
        {
            _item.Armor = _itemDto.Armor;
        }

        public void SetDamage()
        {
            _item.Damage = _itemDto.Damage;
        }

        public void SetDescription()
        {
            _item.Description = _itemDto.Description;
        }

        public void SetHealingAmount()
        {
            _item.Healing = _itemDto.Healing;
        }

        public void SetId()
        {
           _item.Id = _itemDto.Id;
        }

        public void SetItemType()
        {
            _item.Type = _itemDto.ItemType;
        }

        public void SetName()
        {
            _itemDto.Name = _item.Name; 
        }

        public void SetStatistics()
        {
            _item.Statistics.Luck = _itemDto.Luck;
        }
    }
}
