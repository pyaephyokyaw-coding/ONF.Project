namespace ONF.Resume.Pages.Resume;

public class NarutoResumeData
{
    public NarutoResumeData()
    {
    }

    public static ResumeModel GetSampleData()
    {
        return new ResumeModel
        {
            PersonalOverview = new PersonalOverview
            {
                ImageUrl = "/img/naruto.jpg",
                Title = "Full Stack Ninja Developer",
                Name = "Naruto Uzumaki",
                Summary = "A passionate and energetic developer from Konohagakure specializing in scalable web systems and shadow clone distributed computing. Known for perseverance, teamwork, and delivering high-impact results under pressure."
            },
            Contact = new Contact
            {
                Phone = new List<string> { "+81 123 456 789", "+81 987 654 321" },
                Email = "naruto.uzumaki@konoha.dev",
                Address = "7th Hokage Office, Hidden Leaf Village, Fire Country",
                LinkedIn = "https://linkedin.com/in/narutouzumaki",
                GitHub = "https://github.com/naruto-uzumaki",
                Portfolio = "https://narutocodehub.konoha"
            },
            TechnicalSkills = new List<TechnicalSkill>
            {
                new TechnicalSkill
                {
                    Category = "Frontend Development",
                    Skill1 = new List<string> { "HTML", "CSS", "JavaScript" },
                    Skill2 = new List<string> { "React", "Blazor", "Vue" },
                    Skill3 = new List<string> { "Tailwind CSS", "Bootstrap" },
                    Skill4 = new List<string> { "UI/UX Design" },
                    Skill5 = new List<string> { "Responsive Design" }
                },
                new TechnicalSkill
                {
                    Category = "Backend Development",
                    Skill1 = new List<string> { "C#", ".NET Core", "Node.js" },
                    Skill2 = new List<string> { "REST API", "GraphQL" },
                    Skill3 = new List<string> { "SQL Server", "MongoDB" },
                    Skill4 = new List<string> { "Authentication & Authorization" },
                    Skill5 = new List<string> { "Performance Optimization" }
                },
                new TechnicalSkill
                {
                    Category = "Ninja Techniques",
                    Skill1 = new List<string> { "Shadow Clone Technique" },
                    Skill2 = new List<string> { "Rasengan API Implementation" },
                    Skill3 = new List<string> { "Sage Mode Debugging" },
                    Skill4 = new List<string> { "Chakra Load Balancing" },
                    Skill5 = new List<string> { "Nine-Tails Data Security" }
                }
            },
            Projects = new List<Project>
            {
                new Project
                {
                    Name = "Konoha Mission Management System",
                    Date = new DateTime(2023, 10, 1),
                    Description = "A web-based mission tracking system for shinobi teams. Integrated live status updates, mission reports, and automated ranking system using chakra analytics.",
                    Link = "https://konoha-mission.dev"
                },
                new Project
                {
                    Name = "Rasengan Simulation Engine",
                    Date = new DateTime(2024, 6, 15),
                    Description = "Developed a high-performance chakra simulation engine to visualize Rasengan energy flow using WebGL and Blazor.",
                    Link = "https://rasengan-sim.io"
                }
            },
            ProfessionalExperience = new List<ProfessionalExperience>
            {
                new ProfessionalExperience
                {
                    CompanyName = "Hidden Leaf Village Tech Division",
                    Role = "Lead Ninja Developer",
                    Duration = "2019 - Present",
                    Details = new ProfessionalExperience_Details
                    {
                        Responsibilities = new List<string>
                        {
                            "Lead a squad of 10 ninjas in developing secure mission APIs.",
                            "Implemented chakra-based distributed computing system.",
                            "Conducted training for junior ninjas on agile shinobi methods."
                        },
                        Achievements = new List<string>
                        {
                            "Reduced mission report processing time by 80%.",
                            "Won Hokage Award for Innovative Chakra Use in Technology (2023)."
                        }
                    }
                },
                new ProfessionalExperience
                {
                    CompanyName = "Team 7 Projects",
                    Role = "Junior Ninja Developer",
                    Duration = "2015 - 2019",
                    Details = new ProfessionalExperience_Details
                    {
                        Responsibilities = new List<string>
                        {
                            "Assisted Kakashi in developing stealth tracking algorithms.",
                            "Maintained cross-nation messaging system between allied villages.",
                            "Debugged and refactored legacy ninja tool management codebase."
                        },
                        Achievements = new List<string>
                        {
                            "Promoted to Chunin-level Developer within one year.",
                            "Completed 100+ successful team missions without system failure."
                        }
                    }
                }
            },
            Education = new List<Education>
            {
                new Education
                {
                    Institution = "Konoha Ninja Academy",
                    Degree = "Bachelor of Shinobi Science (Specialization in Information Chakra Systems)",
                    Duration = "2008 - 2014",
                    Description = "Graduated top of class with a focus on team collaboration, leadership, and chakra programming principles."
                }
            },
            Certifications = new List<Certifications>
            {
                new Certifications
                {
                    Name = "Certified Hokage Developer",
                    Duration = "2024",
                    Courses = "Advanced Leadership, Scalable Chakra Systems, Peace-Time Governance Algorithms"
                },
                new Certifications
                {
                    Name = "Microsoft .NET Specialist (Leaf Division)",
                    Duration = "2023",
                    Courses = ".NET Core, Blazor WebAssembly, Azure Integration"
                }
            },
            Achievements = new Achievements
            {
                Items = new List<string>
                {
                    "Appointed as 7th Hokage for outstanding leadership and innovation.",
                    "Developed ChakraSync, a cross-village real-time data transfer system.",
                    "First ninja to merge Sage Mode with Machine Learning techniques."
                }
            },
            ResumeFooter = new ResumeFooter
            {
                ContactInfo = "Available for collaboration or mentorship | naruto.uzumaki@konoha.dev",
                SocialMediaLinks = "LinkedIn | GitHub | NinjaBook"
            }
        };
    }
}
