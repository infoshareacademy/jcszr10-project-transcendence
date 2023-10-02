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
          
            GenerateListOfItems();
        }

        //TODO: EnemyInitializer do naprawy
         
        //public void Initialize()
        //{
        //    _enemy.EnemyAttacks = new List<Ability>
        //    {
        //        new Ability(5),
        //        new Ability(7),
        //        new Ability(12),
        //        new Ability(15)
        //    };
        //    _enemy.ItemsToDrop = _enemyItems;
        //}

        public void GenerateListOfItems()
        { 
            // Funkcja, która zapełni liste losowymi przedmiotami w wybranej ilosci z listy _allDroppableItems.
        }

        public void Initialize()
        {
            throw new NotImplementedException();
        }
    }
}
