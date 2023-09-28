
using Project_Transcendence.BuisnessLogic.Models.Perks.Items;

namespace Project_Transcendence.BuisnessLogic.Models.Builders
{
    public interface IItemBuilder
    {
        void SetId();
        void SetName();
        void SetDescription();
        void SetHealingAmount();
        void SetStatistics();
        void SetDamage();
        void SetArmor();
        void SetItemType();



        Item Build();
    }
}
