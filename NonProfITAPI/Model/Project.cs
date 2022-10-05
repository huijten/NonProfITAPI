namespace NonProfITAPI.Model
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Compensation { get; set; }
        public int CreatorId { get; set; }
        public Employee Creator { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public bool Available { get; set; }
    }
}
