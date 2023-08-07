namespace Project_T_WebApp.Models.Items
{
    public interface IItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
