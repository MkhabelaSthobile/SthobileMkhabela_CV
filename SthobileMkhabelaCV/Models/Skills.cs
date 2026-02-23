namespace SthobileMkhabelaCV.Models
{
    public class Skills
    {
        public int Id { get; set; }
        public string SkillName { get; set; }
        public string SkillDescription { get; set; }
        public string TypeOfSkill { get; set; }
        public int MyDetails_Id { get; set; }
        public MyDetails MyDetails { get; set; }

    }
}
