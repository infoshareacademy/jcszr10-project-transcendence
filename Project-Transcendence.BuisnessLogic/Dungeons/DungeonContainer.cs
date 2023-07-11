namespace Project_Transcendence.BuisnessLogic.Dungeons
{
    public static class DungeonContainer
    {
        public static List<IDungeon> Dungeons 
        { 
            get
            {
                return Dungeons;
            }
            set
            {
                Dungeons = new List<IDungeon>()
                {
                    new ShopDungeon(),
                    new EnemyDungeon(),
                    new EnemyDungeon()
                };
            }
        }
    }
}
