namespace SthobileMkhabelaCV.Models
{
    public class Projects
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public string TechStack { get; set; }
        public string ProjectUrl { get; set; }
        public int MyDetails_Id { get; set; }
        public MyDetails MyDetails { get; set; }
    }
}
