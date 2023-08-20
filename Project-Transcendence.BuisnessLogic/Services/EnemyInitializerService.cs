using Project_Transcendence.BuisnessLogic.Models.Character.Enemy;
using Project_Transcendence.BuisnessLogic.Models.Perks.Ability;
using Project_Transcendence.BuisnessLogic.Models.Perks.Items;

namespace Project_Transcendence.BuisnessLogic.Services
{
    public class EnemyInitializerService : IInitializerService
    {

        private readonly IEnemy _enemy;
        private readonly List<IItem> _allDroppableItems;
        private readonly List<IItem> _enemyItems;
        public EnemyInitializerService(IEnemy enemy)
        {
            _enemy = enemy;
            _allDroppableItems = new List<IItem>
            {
                new Jewelery("Pierscionek z brązu", "+1 int", 1, 0, 0, 0),
                new Jewelery("Pierscionek z brązu", "+1 agi", 0, 1, 0, 0),
                new Jewelery("Pierscionek z brązu", "+1 str", 0, 0, 1, 0),
                new Jewelery("Pierscionek z brązu", "+1 luck", 0, 0, 0, 1),
            };
            GenerateListOfItems();
        }

        public void Initialize()
        {
            _enemy.EnemyAttacks = new List<IAbility>
            {
                new Ability(5),
                new Ability(7),
                new Ability(12),
                new Ability(15)
            };
            _enemy.ItemsToDrop = _enemyItems;

        }


        public void GenerateListOfItems()
        { 
            // Funkcja, która zapełni liste losowymi przedmiotami w wybranej ilosci z listy _allDroppableItems.
        }

    }
}
