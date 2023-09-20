using Project_Transcendence.BuisnessLogic.Models.Character.Player;


namespace Project_Transcendence.BuisnessLogic.Models.Character
{
    public class User : IUser
    {

        public int Id { get; set; }
        public PlayerCharacter  Character { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

    }
}
