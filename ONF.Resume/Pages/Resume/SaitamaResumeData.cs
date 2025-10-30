namespace ONF.Resume.Pages.Resume;

public class SaitamaResumeData
{
    public static ResumeModel GetSampleData()
    {
        return new ResumeModel
        {
            PersonalOverview = new PersonalOverview
            {
                Title = "Professional Hero / Full Stack Developer",
                Name = "Saitama",
                Summary = "A highly dedicated and adaptable professional known for completing any task with a single punch. " +
                          "Blends strong problem-solving skills, extreme focus, and unmatched efficiency both in combat and in code. " +
                          "Passionate about automation, optimization, and saving the world before lunch.",
                ImageUrl = "img/saitama.jpg"
            },

            Contact = new Contact
            {
                Phone = new List<string> { "+81 999 888 7777" },
                Email = "saitama@heroassociation.jp",
                Address = "Z-City, Japan",
                LinkedIn = "https://linkedin.com/in/saitama-onepunch",
                GitHub = "https://github.com/onepunchdev",
                Portfolio = "https://saitama.dev"
            },

            TechnicalSkills = new List<TechnicalSkill>
    {
        new TechnicalSkill
        {
            Category = "Frontend Development",
            Skill1 = new List<string> { "HTML", "CSS", "JavaScript" },
            Skill2 = new List<string> { "React", "Blazor" },
            Skill3 = new List<string> { "TailwindCSS", "Bootstrap" }
        },
        new TechnicalSkill
        {
            Category = "Backend Development",
            Skill1 = new List<string> { "C#", ".NET 8", "ASP.NET Core" },
            Skill2 = new List<string> { "Entity Framework", "RESTful APIs" },
            Skill3 = new List<string> { "SQL Server", "PostgreSQL" }
        },
        new TechnicalSkill
        {
            Category = "DevOps & Tools",
            Skill1 = new List<string> { "Docker", "Git", "Azure DevOps" },
            Skill2 = new List<string> { "CI/CD Pipelines", "Unit Testing" }
        },
        new TechnicalSkill
        {
            Category = "Other Skills",
            Skill1 = new List<string> { "Team Leadership", "Stress Tolerance", "High-Speed Problem Solving" }
        }
    },

            Projects = new List<Project>
    {
        new Project
        {
            Name = "Hero Management System",
            Date = new DateTime(2024, 6, 1),
            Description = "Developed a centralized web platform for the Hero Association to manage hero data, rankings, and missions. " +
                          "Integrated live alerts for emergency threats using real-time APIs.",
            Link = "https://github.com/onepunchdev/hero-management-system"
        },
        new Project
        {
            Name = "One Punch Task Scheduler",
            Date = new DateTime(2023, 10, 15),
            Description = "A lightweight .NET scheduler app that automates and completes system tasks with one command — " +
                          "inspired by Saitama’s efficiency philosophy.",
            Link = "https://github.com/onepunchdev/task-scheduler"
        }
    },

            ProfessionalExperience = new List<ProfessionalExperience>
    {
        new ProfessionalExperience
        {
            CompanyName = "Hero Association",
            Role = "S-Class Professional Hero",
            Duration = "2015 - Present",
            Details = new ProfessionalExperience_Details
            {
                Responsibilities = new List<string>
                {
                    "Respond to high-level threats across Z-City within seconds.",
                    "Collaborate with other heroes to ensure civilian safety.",
                    "Assist in developing digital infrastructure for hero coordination."
                },
                Achievements = new List<string>
                {
                    "Eliminated multiple dragon-level threats with minimal collateral damage.",
                    "Maintained a 100% mission success rate.",
                    "Optimized crisis response workflow by introducing digital alert systems."
                }
            }
        },
        new ProfessionalExperience
        {
            CompanyName = "Freelance Developer",
            Role = "Full Stack Engineer",
            Duration = "2018 - Present",
            Details = new ProfessionalExperience_Details
            {
                Responsibilities = new List<string>
                {
                    "Developed small to medium-scale web apps for local businesses.",
                    "Provided code reviews, mentoring, and system optimizations.",
                    "Maintained high code quality and system performance."
                },
                Achievements = new List<string>
                {
                    "Completed projects ahead of deadlines using extreme focus.",
                    "Reduced client system load times by 70%.",
                    "Implemented simplified UI/UX that even Genos could understand."
                }
            }
        }
    },

            Education = new List<Education>
    {
        new Education
        {
            Institution = "Z-City Coding Academy",
            Degree = "Diploma in Software Engineering",
            Duration = "2013 - 2015",
            Description = "Focused on C#, .NET development, and practical applications in real-world hero systems."
        }
    },

            Certifications = new List<Certifications>
    {
        new Certifications
        {
            Name = "Microsoft Certified: Azure Developer Associate",
            Duration = "2022 - Present",
            Courses = "Azure App Services, Functions, DevOps Integration"
        },
        new Certifications
        {
            Name = "Hero Association Certification - S-Class",
            Duration = "2015 - Present",
            Courses = "Combat Tactics, Ethics, and Disaster Management"
        }
    },

            Achievements = new Achievements
            {
                Items = new List<string>
        {
            "Defeated every known opponent with a single punch.",
            "Ranked as top S-Class hero by public admiration.",
            "Built hero mission web system with 99.99% uptime."
        }
            },

            ResumeFooter = new ResumeFooter
            {
                ContactInfo = "Reach out for collaborations or system rescue missions.",
                SocialMediaLinks = "GitHub | LinkedIn | Hero Association"
            }
        };
    }
}
