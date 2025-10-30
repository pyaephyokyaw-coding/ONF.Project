namespace ONF.Resume.Pages.Resume;

public class GojoResumeData
{
    public static ResumeModel GetSampleData()
    {
        return new ResumeModel
        {
            PersonalOverview = new PersonalOverview
            {
                ImageUrl = "img/satorugojo.jpg",
                Title = "Senior Full Stack Developer & System Architect",
                Name = "Satoru Gojo",
                Summary = "A visionary full-stack developer with limitless coding ability and unmatched system design skills. Known for building ultra-secure, high-performance applications and mentoring future engineers. Believes in breaking boundaries and redefining development standards."
            },
            Contact = new Contact
            {
                Phone = new List<string> { "+81 555 888 000" },
                Email = "gojo.satoru@jjtech.dev",
                Address = "Jujutsu High, Tokyo Prefecture, Japan",
                LinkedIn = "https://linkedin.com/in/satorugojo",
                GitHub = "https://github.com/gojo-satoru",
                Portfolio = "https://limitless.dev"
            },
            TechnicalSkills = new List<TechnicalSkill>
            {
                new TechnicalSkill
                {
                    Category = "Frontend Development",
                    Skill1 = new List<string> { "React", "Next.js", "Blazor", "TypeScript" },
                    Skill2 = new List<string> { "Tailwind CSS", "SASS", "Three.js" },
                    Skill3 = new List<string> { "Progressive Web Apps (PWA)" },
                    Skill4 = new List<string> { "UI Performance Optimization" },
                    Skill5 = new List<string> { "Responsive & Motion Design" }
                },
                new TechnicalSkill
                {
                    Category = "Backend Development",
                    Skill1 = new List<string> { "C#", ".NET 8", "Node.js", "Go" },
                    Skill2 = new List<string> { "Microservices Architecture", "gRPC", "RESTful APIs" },
                    Skill3 = new List<string> { "SQL Server", "Redis", "MongoDB" },
                    Skill4 = new List<string> { "Authentication, Authorization & Encryption" },
                    Skill5 = new List<string> { "High Concurrency Optimization" }
                },
                new TechnicalSkill
                {
                    Category = "Special Abilities",
                    Skill1 = new List<string> { "Domain Expansion: Infinite Debugging" },
                    Skill2 = new List<string> { "Limitless Algorithm Optimization" },
                    Skill3 = new List<string> { "Six Eyes Monitoring System" },
                    Skill4 = new List<string> { "Bug Exorcism Framework" },
                    Skill5 = new List<string> { "Jujutsu Cloud Architecture" }
                }
            },
            Projects = new List<Project>
            {
                new Project
                {
                    Name = "Infinity Security Framework",
                    Date = new DateTime(2024, 2, 14),
                    Description = "Developed a next-generation cybersecurity framework capable of nullifying all known vulnerabilities using predictive anomaly detection. Designed with adaptive AI shielding.",
                    Link = "https://infinity-secure.io"
                },
                new Project
                {
                    Name = "Six Eyes Analytics Engine",
                    Date = new DateTime(2023, 7, 10),
                    Description = "Created an ultra-fast analytical engine with real-time visibility into system health, network flow, and user behavior using .NET and Azure Event Grid.",
                    Link = "https://sixeyes.dev"
                }
            },
            ProfessionalExperience = new List<ProfessionalExperience>
            {
                new ProfessionalExperience
                {
                    CompanyName = "Jujutsu High Tech Division",
                    Role = "Principal Software Architect",
                    Duration = "2020 - Present",
                    Details = new ProfessionalExperience_Details
                    {
                        Responsibilities = new List<string>
                        {
                            "Architected and led enterprise-level secure software ecosystems.",
                            "Trained and mentored elite developers (students) to adopt best coding practices.",
                            "Implemented next-gen AI-assisted debugging and threat mitigation tools."
                        },
                        Achievements = new List<string>
                        {
                            "Introduced Limitless Framework — a system that prevents runtime errors in production.",
                            "Awarded 'Top Developer in Japan' by Jujutsu Engineering Association (2024)."
                        }
                    }
                },
                new ProfessionalExperience
                {
                    CompanyName = "Sorcerer Systems Co.",
                    Role = "Senior Software Engineer",
                    Duration = "2015 - 2020",
                    Details = new ProfessionalExperience_Details
                    {
                        Responsibilities = new List<string>
                        {
                            "Developed core microservices handling millions of concurrent requests.",
                            "Designed multi-layer security models for enterprise clients.",
                            "Led transition from monolithic to distributed architecture."
                        },
                        Achievements = new List<string>
                        {
                            "Reduced server load by 95% with advanced caching strategy.",
                            "Recognized for flawless system uptime — 100% SLA compliance."
                        }
                    }
                }
            },
            Education = new List<Education>
            {
                new Education
                {
                    Institution = "Tokyo Jujutsu Technical Institute",
                    Degree = "Master of Software Sorcery & AI Systems",
                    Duration = "2010 - 2014",
                    Description = "Focused on algorithmic theory, machine learning, and cursed data security. Graduated as top sorcerer engineer with distinction in advanced system design."
                }
            },
            Certifications = new List<Certifications>
            {
                new Certifications
                {
                    Name = "Certified Limitless Architect (CLA)",
                    Duration = "2024",
                    Courses = "AI-driven Security, System Resilience, Dimensional Debugging"
                },
                new Certifications
                {
                    Name = "Microsoft Azure Supreme Architect",
                    Duration = "2023",
                    Courses = "Cloud Architecture, Performance Scaling, Real-time Analytics"
                }
            },
            Achievements = new Achievements
            {
                Items = new List<string>
                {
                    "Invented the 'Limitless Framework' — zero-error runtime system.",
                    "Mentored top engineers like Yuji Itadori and Megumi Fushiguro in full-stack mastery.",
                    "Built a real-time data shield preventing over 1M cyber attacks per second."
                }
            },
            ResumeFooter = new ResumeFooter
            {
                ContactInfo = "Contact me if you can handle infinite performance. | gojo.satoru@jjtech.dev",
                SocialMediaLinks = "LinkedIn | GitHub | SorcererNet"
            }
        };
    }
}

