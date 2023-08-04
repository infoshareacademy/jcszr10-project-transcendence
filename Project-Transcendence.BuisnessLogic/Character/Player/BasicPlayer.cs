using Project_Transcendence.BuisnessLogic.Character.CharacterClasses;
using Project_Transcendence.BuisnessLogic.Character.CharacterRaces;
using Project_Transcendence.BuisnessLogic.Perks.Ability;
using Project_Transcendence.BuisnessLogic.Perks.Items;

namespace Project_Transcendence.BuisnessLogic.Character.Player
{
    public class BasicPlayer : BasicCharacter, IPlayer, IStatistics, IInventory, IHealth
    {
        public ICharacterClass CharacterClass { get; set; }
        public int Experience { get; set; }
        public List<Item> Inventory { get; set; }
        public List<Item> Gear { get; set; }
        public List<Weapon> Weapons { get; set; }
        public List<Jewelery> Jewelery { get; set; }
        private StatisticsManager _statisticsManager { get; set; }
        private HealthManager _healthManager { get; set; }

        public BasicPlayer(string name, ICharacterRace race, ICharacterClass characterClass, int startingHealth, int startingExp, int level)
        {
            Name = name;
            Race = race;
            CharacterClass = characterClass;
            Level = level;
            Experience = startingExp;
            Inventory = new List<Item>();
            Gear = new List<Item>();
            Weapons = new List<Weapon>();
            Jewelery = new List<Jewelery>();
            // Weapons.Add(new Weapon());
            _statisticsManager = new StatisticsManager(10, 10, 10, 10);
            _healthManager = new HealthManager(startingHealth);

            Jewelery.Add(new Jewelery("ring","description",0,0,0,5));
            Jewelery.Add(new Jewelery("necklace", "description",0,0,0,5));


        }

        /// <summary>
        /// This class returns int value that represents chosen statistic: agility,intelect,strength,luck.
        /// </summary>
        /// <param name="statisticType"></param>
        /// <returns></returns>
        public int CalculateStatistic(string statisticType)
        {
            int result = 0;
            switch (statisticType)
            {
                case "intelect":

                    foreach (var item in Jewelery)
                    {
                        result += item.GetIntelect();
                    }
                    break;

                case "agility":

                    foreach (var item in Jewelery)
                    {
                        result += item.GetAgility();
                    }
                    break;

                case "strength":

                    foreach (var item in Jewelery)
                    {
                        result += item.GetStrength();
                    }
                    break;

                case "luck":

                    foreach (var item in Jewelery)
                    {
                        result += item.GetLuck();
                    }
                    break;

                default:
                    result = 0;
                    break;
            }

            return result;
        }

        #region // Health and statistic management

        public int GetHealth()
        {
            return _healthManager.GetHealth();
        }

        public int GetIntelect()
        {
            return _statisticsManager.Intelect + Race.GetCharacterIntelect() + CalculateStatistic("intelect");
        }

        public int GetLuck()
        {
            return _statisticsManager.Luck + Race.GetCharacterLuck() + CalculateStatistic("luck");
        }

        public int GetAgility()
        {
            return _statisticsManager.Agility + Race.GetCharacterAgility() + CalculateStatistic("agility");
        }

        public int GetStrength()
        {
           return _statisticsManager.Strength + Race.GetCharacterStrength() + CalculateStatistic("strength");
        }

        public void IncreaseIntelect(int x)
        {
            _statisticsManager.IncreaseIntelect(x);
        }

        public void IncreaseAgility(int x)
        {
            _statisticsManager.IncreaseAgility(x);
        }

        public void IncreaseStrength(int x)
        {
            _statisticsManager.IncreaseStrength(x);
        }

        public void IncreaseLuck(int x)
        {
            _statisticsManager.IncreaseLuck(x);
        }

        public void IncreaseStatistics(int x)
        {
            IncreaseAgility(x);
            IncreaseIntelect(x);
            IncreaseLuck(5);
            IncreaseStrength(x);
        }

        public void AddExperience()
        {
            Experience++;
            //TODO: Design exp system 
        }

        public void AddToInventory(Item item)
        {
            Inventory.Add(item);
        }

        public void AddToJewelery(Item item)
        {
            //Jewelery.Add(item);
        }

        public void AddToWeapons(Item item)
        {
            //Weapons.Add(item);
        }

        public void RemoveFromInventory(Item item)
        {
            //Inventory.Remove(item);
        }

        public void RemoveFromJewelery(Item item)
        {
            //Jewelery.Remove(item);
        }

        public void RemoveFromWeapons(Item item)
        {
            //Weapons.Remove(item);
        }

        public void TakeDamage(IAbility ability)
        {
            _healthManager.DecreaseHealth(ability.Damage);
        }

        public void TakeDamage(int damage)
        {
            _healthManager.DecreaseHealth((int)damage);
        }

        public void TakeHealth(IAbility ability)
        {
            _healthManager.IncreaseHealth(ability.Healing);
        }

        public void TakeHealth(int healing)
        {
            _healthManager.IncreaseHealth((int)healing);
        }

        public void IncreaseLevel()
        {
            Level++;
            Experience = 0;
        }

        public string GetCharacterClass()
        {
            return CharacterClass.GetType().ToString();
        }

        public override string ToString()
        {
            return $"Imie: {Name} Rasa: {Race.GetCharacterRaceName()} Klasa: {CharacterClass.ClassName} Poziom: {Level} Punkty doświadczenia: {Experience}";
        }

        #endregion

        public void LevelUp()
        {
            if(Experience >= 0)
            {
                _healthManager.IncreaseHealth(100);
                IncreaseStatistics(5);
                IncreaseLevel();
            }
        }
    }
}
