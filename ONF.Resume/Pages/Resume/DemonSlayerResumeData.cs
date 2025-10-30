namespace ONF.Resume.Pages.Resume;

public class DemonSlayerResumeData
{
    public static ResumeModel GetSampleData()
    {
        return new ResumeModel
        {
            PersonalOverview = new PersonalOverview
            {
                ImageUrl = "img/tanjiro.jpg",
                Title = "Full Stack Demon Slayer Developer",
                Name = "Tanjiro Kamado",
                Summary = "Dedicated and compassionate developer from the mountains of Japan. Skilled in clean code, responsive design, and debugging under intense pressure. Balances empathy and precision to deliver applications that heal user pain points — just as he slays bugs like demons."
            },
            Contact = new Contact
            {
                Phone = new List<string> { "+81 999 777 555" },
                Email = "tanjiro.kamado@demoncorp.dev",
                Address = "Butterfly Estate, Taisho-era Japan",
                LinkedIn = "https://linkedin.com/in/tanjirokamado",
                GitHub = "https://github.com/tanjiro-dev",
                Portfolio = "https://tanjirocodeforge.com"
            },
            TechnicalSkills = new List<TechnicalSkill>
            {
                new TechnicalSkill
                {
                    Category = "Frontend Development",
                    Skill1 = new List<string> { "HTML", "CSS", "JavaScript" },
                    Skill2 = new List<string> { "React", "Blazor", "Angular" },
                    Skill3 = new List<string> { "Tailwind CSS", "SASS" },
                    Skill4 = new List<string> { "Responsive UI/UX Design" },
                    Skill5 = new List<string> { "Accessibility & Performance" }
                },
                new TechnicalSkill
                {
                    Category = "Backend Development",
                    Skill1 = new List<string> { "C#", ".NET Core", "Node.js" },
                    Skill2 = new List<string> { "REST API", "Entity Framework", "SQL Server" },
                    Skill3 = new List<string> { "Authentication & Security" },
                    Skill4 = new List<string> { "Server Optimization" },
                    Skill5 = new List<string> { "Testing & Debugging" }
                },
                new TechnicalSkill
                {
                    Category = "Special Abilities",
                    Skill1 = new List<string> { "Breath of Water Algorithms" },
                    Skill2 = new List<string> { "Demon Debugging Techniques" },
                    Skill3 = new List<string> { "Smell Detection for Code Bugs" },
                    Skill4 = new List<string> { "Synchronous Sword and Code Style" },
                    Skill5 = new List<string> { "Emotional Intelligence in Teamwork" }
                }
            },
            Projects = new List<Project>
            {
                new Project
                {
                    Name = "Demon Tracker System",
                    Date = new DateTime(2023, 12, 15),
                    Description = "A web app built to track demon activity logs and coordinate slayer teams. Features data visualization, alert notifications, and region-based mission analytics.",
                    Link = "https://demonslayer-tracker.dev"
                },
                new Project
                {
                    Name = "Nichirin Blade Simulator",
                    Date = new DateTime(2024, 5, 25),
                    Description = "Developed a real-time simulator using Blazor WebAssembly and Three.js to visualize sword movements and elemental attacks through interactive 3D rendering.",
                    Link = "https://nichirin-sim.io"
                }
            },
            ProfessionalExperience = new List<ProfessionalExperience>
            {
                new ProfessionalExperience
                {
                    CompanyName = "Demon Slayer Corps Tech Division",
                    Role = "Full Stack Developer & Bug Slayer",
                    Duration = "2020 - Present",
                    Details = new ProfessionalExperience_Details
                    {
                        Responsibilities = new List<string>
                        {
                            "Developed mission management and reporting systems.",
                            "Optimized real-time alert APIs for slayer coordination.",
                            "Trained junior developers (slayers) in code discipline and clean structure."
                        },
                        Achievements = new List<string>
                        {
                            "Reduced system response time by 70% under high load.",
                            "Awarded 'Hashira of Code Excellence' for consistent performance."
                        }
                    }
                },
                new ProfessionalExperience
                {
                    CompanyName = "Urokodaki Software Dojo",
                    Role = "Apprentice Developer",
                    Duration = "2016 - 2020",
                    Details = new ProfessionalExperience_Details
                    {
                        Responsibilities = new List<string>
                        {
                            "Learned fundamentals of clean and modular coding.",
                            "Implemented small web modules and assisted in backend tasks.",
                            "Helped maintain internal dojo app for training schedule management."
                        },
                        Achievements = new List<string>
                        {
                            "Graduated top of class for code discipline.",
                            "Successfully deployed the 'Breath of Water Framework' for dojo usage."
                        }
                    }
                }
            },
            Education = new List<Education>
            {
                new Education
                {
                    Institution = "Mount Sagiri Coding Academy",
                    Degree = "Bachelor of Software Engineering & Digital Combat Design",
                    Duration = "2012 - 2016",
                    Description = "Studied programming, data structures, and combat simulation systems. Focused on performance optimization and empathy-driven design principles."
                }
            },
            Certifications = new List<Certifications>
            {
                new Certifications
                {
                    Name = "Certified Hashira Developer",
                    Duration = "2024",
                    Courses = "Advanced Debugging, Emotional AI Systems, Performance Breath Techniques"
                },
                new Certifications
                {
                    Name = "Microsoft Azure Demon Cloud Specialist",
                    Duration = "2023",
                    Courses = "Cloud Deployment, Scalable Mission Infrastructure, Security Against Demonic Threats"
                }
            },
            Achievements = new Achievements
            {
                Items = new List<string>
                {
                    "Saved thousands of users from code demons through bug purification.",
                    "Developed Water Breathing Framework, now used across Demon Corps.",
                    "Collaborated with Hashira Division to integrate chakra-based monitoring systems."
                }
            },
            ResumeFooter = new ResumeFooter
            {
                ContactInfo = "Always open to collaborations that make the digital world safer. | tanjiro.kamado@demoncorp.dev",
                SocialMediaLinks = "LinkedIn | GitHub | DemonNet"
            }
        };
    }
}

