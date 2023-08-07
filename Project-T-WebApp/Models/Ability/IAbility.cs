namespace Project_T_WebApp.Models.Ability
{
    public interface IAbility
    {
        public int Id { get; set; }
        public int Damage { get; set; }
        public int Healing { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
