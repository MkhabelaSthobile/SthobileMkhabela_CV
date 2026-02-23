namespace SthobileMkhabelaCV.Models
{
    public class MyDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string ProfessionalTitle { get; set; }
        public string ImageUrl { get; set; }
        public string GitHubLink { get; set; }
        public string AboutMe { get; set; }
        public List<Skills> Skills { get; set; }
        public List<Projects> Projects { get; set; }
        public List<Education> Education { get; set; }

    }
}
