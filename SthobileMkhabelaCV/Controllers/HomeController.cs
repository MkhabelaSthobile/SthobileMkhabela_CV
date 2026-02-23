using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using SthobileMkhabelaCV.Models;

namespace SthobileMkhabelaCV.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/Index  (or just /)
        public IActionResult Index()
        {
            var details = GetMyDetails();
            return View(details);
        }

        // Optional: a dedicated page per section if you go multi-page
        public IActionResult About()
        {
            var details = GetMyDetails();
            return View(details);
        }

        public IActionResult Projects()
        {
            var details = GetMyDetails();
            return View(details.Projects);
        }

        public IActionResult Skills()
        {
            var details = GetMyDetails();
            return View(details.Skills);
        }

        public IActionResult Education()
        {
            var details = GetMyDetails();
            return View(details.Education);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = System.Diagnostics.Activity.Current?.Id
                            ?? HttpContext.TraceIdentifier
            });
        }

        private MyDetails GetMyDetails()
        {
            return new MyDetails
            {
                Id = 1,
                Name = "Sthobile",
                Surname = "Mkhabela",
                Email = "MkhabelaSthobile@email.com",
                ProfessionalTitle = "Final-Year IT Student | Aspiring Software Developer",
                ImageUrl = "/images/Profile.jpg",  
                GitHubLink = "https://github.com/MkhabelaSthobile/SthobileMkhabela_CV.git",
                AboutMe = "A motivated IT student passionate about software development, problem-solving, and building efficient digital solutions. " + 
                          "Dedicated to using technology to create practical solutions that benefit and improve everyday life.",

                Skills = new List<Skills>
                {
                    new Skills { Id = 1, SkillName = "C#",           SkillDescription = "Backend development with ASP.NET MVC & Core",  TypeOfSkill = "Backend",   MyDetails_Id = 1 },
                    new Skills { Id = 2, SkillName = "HTML",         SkillDescription = "Responsive, accessible front-end markup",      TypeOfSkill = "Frontend", MyDetails_Id = 1 },
                    new Skills { Id = 3, SkillName = "SQL Server",   SkillDescription = "Relational database design and queries",       TypeOfSkill = "Database", MyDetails_Id = 1 },
                    new Skills { Id = 4, SkillName = "Git & GitHub", SkillDescription = "Version control and collaborative workflows",  TypeOfSkill = "DevOps",   MyDetails_Id = 1 },
                    new Skills { Id = 5, SkillName = "Strong teamwork and collaboration", SkillDescription = " ",                       TypeOfSkill = "Soft Skills",   MyDetails_Id = 1 },
                    new Skills { Id = 6, SkillName = "Excellent communication and interpersonal skills", SkillDescription = " ",        TypeOfSkill = "Soft Skills",   MyDetails_Id = 1 },
                    new Skills { Id = 7, SkillName = "Leadership abilities", SkillDescription = " ",                                    TypeOfSkill = "Soft Skills",   MyDetails_Id = 1 },
                    new Skills { Id = 8, SkillName = "Time management and reliability ", SkillDescription = " ",                        TypeOfSkill = "Soft Skills",   MyDetails_Id = 1 },
                    

                },

                Projects = new List<Projects>
                {
                    new Projects
                    {
                        Id = 1,
                        ProjectName  = "Contract Monthly Claim System",
                        Description  = "A claim management system used to track the monthly claims of users that have different roles (e.g., Admin, Lecturer, Coordinator and Manager) within the system",
                        TechStack    = "ASP.NET MVC, C#, HTML, CSS, Bootstrap",
                        ProjectUrl   = "https://github.com/MkhabelaSthobile/ST10448774_PROG6212_POEPart_3.git",
                        MyDetails_Id = 1
                    }
                    
                },

                Education = new List<Education>
                {
                    new Education
                    {
                        Id              = 1,
                        InstitutionName = "St. Catherine’s School Empangeni",
                        Qualification   = "National Senior Certificate (NSC)",
                        GraduationYear  = 2023,
                        Description     = "Subjects: English, Mathematics, Life Orientation, Isizulu, Physical Sciences, \r\nComputer Applications Technology (CAT), and Accounting",
                        MyDetails_Id    = 1
                    },
                    new Education
                    {
                        Id              = 2,
                        InstitutionName = "Emeris Ruimsig",
                        Qualification   = "Bachelor of Computer and Information Sciences in Application Development",
                        GraduationYear  = 2026,
                        Description     = "Modules completed (Year 1 & 2):  \n Mathematical Principles for Computer Science; \r\n Programming (1A, 1B, 2A, 2B); \r\n Network Engineering (1A, 1B); \r\n Programming Logic and Design; \r\no Principles of Security; \r\n IT Professional Practice; \r\n Cloud Development (A, B); \r\n Information Systems (1B, 2A, 2B, 2C)",
                        MyDetails_Id    = 1
                    },

                }
            };
        }
    }
}