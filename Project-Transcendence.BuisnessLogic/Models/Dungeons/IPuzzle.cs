namespace Project_Transcendence.BuisnessLogic.Models.Dungeons
{
    public interface IPuzzle
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public List<string> Answers { get; set; }
        public string GoodAnswer { get; set; }
    }
}
