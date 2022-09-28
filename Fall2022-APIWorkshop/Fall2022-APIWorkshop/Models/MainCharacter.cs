namespace Fall2022_APIWorkshop.Models
{
    public class MainCharacter
    {
        public int Id { get; set; } // Think of this as a key
        public string Name { get; set; }
        public int VideoGameId { get; set; } // THis value is the "foreign key" that will be pointing to a video game in another table
        public virtual VideoGame VideoGame { get; set; } // This is the virtual video game object - virtual allows this to be overriden or referenced elsewhere

    }
}
