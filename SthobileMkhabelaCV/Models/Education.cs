namespace SthobileMkhabelaCV.Models
{
    public class Education
    {
        public int Id { get; set; }
        public string InstitutionName { get; set; }
        public string Qualification { get; set; }
        public int GraduationYear { get; set; }
        public string Description { get; set; }
        public int MyDetails_Id { get; set; }
        public MyDetails MyDetails { get; set; }
    }
}
