namespace Fall2022_APIWorkshop.Models
{
    public class VideoGame
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int StudioId { get; set; }  
        public virtual Studio Studio { get; set;} // note this will become a model
        public virtual MainCharacter MainCharacter { get; set; } // this will also become a model
        // We are going to want a list of tags (categories, etc.) that are associated with this game
    }
}
