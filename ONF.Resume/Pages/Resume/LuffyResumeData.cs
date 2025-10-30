namespace ONF.Resume.Pages.Resume;

public class LuffyResumeData
{
    public LuffyResumeData()
    {
    }

    public static ResumeModel GetSampleData()
    {
        return new ResumeModel
        {
            PersonalOverview = new PersonalOverview
            {
                ImageUrl = "img/luffy.jpg",
                Title = "Full Stack Pirate Developer",
                Name = "Monkey D. Luffy",
                Summary = "A fearless and ambitious developer with a dream to become the Pirate King of Technology. Skilled in building resilient, scalable web systems that can weather any storm. Believes in teamwork, adventure, and stretching beyond limits."
            },
            Contact = new Contact
            {
                Phone = new List<string> { "+81 111 222 333" },
                Email = "luffy@strawhat.dev",
                Address = "Thousand Sunny Ship, Grand Line, East Blue",
                LinkedIn = "https://linkedin.com/in/monkeydluffy",
                GitHub = "https://github.com/strawhat-luffy",
                Portfolio = "https://luffypiratecode.io"
            },
            TechnicalSkills = new List<TechnicalSkill>
            {
                new TechnicalSkill
                {
                    Category = "Frontend Development",
                    Skill1 = new List<string> { "React", "Blazor", "Vue" },
                    Skill2 = new List<string> { "HTML", "CSS", "JavaScript" },
                    Skill3 = new List<string> { "Tailwind CSS", "Bootstrap" },
                    Skill4 = new List<string> { "Dynamic UI Design" },
                    Skill5 = new List<string> { "Accessibility Optimization" }
                },
                new TechnicalSkill
                {
                    Category = "Backend Development",
                    Skill1 = new List<string> { "C#", ".NET Core", "Node.js" },
                    Skill2 = new List<string> { "REST API", "gRPC", "GraphQL" },
                    Skill3 = new List<string> { "PostgreSQL", "MongoDB" },
                    Skill4 = new List<string> { "Microservices Architecture" },
                    Skill5 = new List<string> { "Docker & Kubernetes" }
                },
                new TechnicalSkill
                {
                    Category = "Special Abilities",
                    Skill1 = new List<string> { "Gum-Gum Code Stretching" },
                    Skill2 = new List<string> { "Haki-based Security Implementation" },
                    Skill3 = new List<string> { "Agile Scrum Mastery (Pirate Version)" },
                    Skill4 = new List<string> { "Cloud Navigation using Log Pose Data" },
                    Skill5 = new List<string> { "Sea of Code (Full Stack Integration)" }
                }
            },
            Projects = new List<Project>
            {
                new Project
                {
                    Name = "Straw Hat Crew Management System",
                    Date = new DateTime(2023, 8, 10),
                    Description = "Built a cross-platform crew management app to track bounty updates, ship logistics, and daily adventures. Features offline-first capability for sea voyages.",
                    Link = "https://strawhatcrew.io"
                },
                new Project
                {
                    Name = "One Piece Tracker API",
                    Date = new DateTime(2024, 4, 20),
                    Description = "Designed an API to aggregate treasure hunt data, route maps, and enemy ship locations using AI and oceanic data analytics.",
                    Link = "https://onepiece-api.dev"
                }
            },
            ProfessionalExperience = new List<ProfessionalExperience>
            {
                new ProfessionalExperience
                {
                    CompanyName = "Straw Hat Innovations",
                    Role = "Captain & Lead Developer",
                    Duration = "2019 - Present",
                    Details = new ProfessionalExperience_Details
                    {
                        Responsibilities = new List<string>
                        {
                            "Led a distributed development team of 9 members (crew).",
                            "Created scalable applications used across multiple seas (networks).",
                            "Integrated data synchronization with Log Pose cloud services."
                        },
                        Achievements = new List<string>
                        {
                            "Launched 10+ successful projects despite turbulent environments.",
                            "Awarded 'King of Full Stack Seas' at Grand Line DevCon 2024."
                        }
                    }
                },
                new ProfessionalExperience
                {
                    CompanyName = "Red-Haired Pirates Tech Co.",
                    Role = "Junior Developer (Apprentice)",
                    Duration = "2015 - 2019",
                    Details = new ProfessionalExperience_Details
                    {
                        Responsibilities = new List<string>
                        {
                            "Assisted Shanks in maintaining the distributed communication app 'SeaChat'.",
                            "Developed small modules for bounty system integration.",
                            "Participated in agile sprints while sailing the Grand Line."
                        },
                        Achievements = new List<string>
                        {
                            "Recognized for extraordinary adaptability and optimism.",
                            "Survived multiple data leaks and ship downtimes with zero data loss."
                        }
                    }
                }
            },
            Education = new List<Education>
            {
                new Education
                {
                    Institution = "East Blue Coding Academy",
                    Degree = "Bachelor of Maritime Software Engineering",
                    Duration = "2010 - 2014",
                    Description = "Studied algorithmic sea navigation, distributed computing over long distances, and pirate ethics in open-source collaboration."
                }
            },
            Certifications = new List<Certifications>
            {
                new Certifications
                {
                    Name = "Certified Pirate Developer (CPD)",
                    Duration = "2023",
                    Courses = "Ocean Network Design, Treasure Data Mining, Open-Sea Security"
                },
                new Certifications
                {
                    Name = "Azure Cloud Sailor",
                    Duration = "2024",
                    Courses = "Cloud Deployment, Scalability on High Waves, Sea Route Data Storage"
                }
            },
            Achievements = new Achievements
            {
                Items = new List<string>
                {
                    "Founded Straw Hat Innovations, a decentralized tech crew.",
                    "Discovered and deployed the legendary One Piece API.",
                    "Built the first shipboard microservice cluster on the Thousand Sunny."
                }
            },
            ResumeFooter = new ResumeFooter
            {
                ContactInfo = "Always open for collaboration — reach me at luffy@strawhat.dev",
                SocialMediaLinks = "LinkedIn | GitHub | GrandLineConnect"
            }
        };
    }
}

