namespace Fall2022_APIWorkshop.Models
{
    public class Studio
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public int EmployeeCount { get; set; }
        // video games made by this studio. What do we need?: A collection!
        public virtual List<VideoGame> VideoGames { get; set; }

    }
}
