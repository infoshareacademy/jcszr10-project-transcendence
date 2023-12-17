
using Project_Transcendence.BuisnessLogic.Models.DTOs;
using Project_Transcendence.BuisnessLogic.Models.Perks.Items;

namespace Project_Transcendence.BuisnessLogic.Models.Builders
{
    public class ItemBuilder : IItemBuilder
    {
        private readonly ItemDto _itemDto;
        private readonly Item _item;

        public ItemBuilder(ItemDto itemDto)
        {
            _itemDto = itemDto;
            _item = new Item();
            _item.Statistics = new(0,0,0,0);
        }

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
            _item.ItemType = _itemDto.ItemType;
        }

        public void SetName()
        {
            _item.Name = _itemDto.Name;
        }

        public void SetStatistics()
        {
            _item.Statistics.Luck = _itemDto.Luck;
            _item.Statistics.Agility = _itemDto.Agility;
            _item.Statistics.Intelect = _itemDto.Intelect;
            _item.Statistics.Strength = _itemDto.Strength;
        }
    }
}
