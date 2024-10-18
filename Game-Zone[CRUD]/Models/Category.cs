namespace Game_Zone_CRUD_.Models
{
    public class Category : BaseEntity
    {
        public ICollection<Game> Games { get; set; } = new List<Game>();
    }
}
