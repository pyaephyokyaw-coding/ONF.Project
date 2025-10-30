namespace ONF.Resume.Pages.Resume;

public class SungJinwooResumeData
{
    public static ResumeModel GetSampleData()
    {
        return new ResumeModel
        {
            PersonalOverview = new PersonalOverview
            {
                Title = "S-Rank Hunter / Shadow Monarch / System Administrator",
                Name = "Sung Jinwoo",
                Summary = "Highly adaptable and resilient professional specializing in monster suppression, shadow command systems, and dimensional security. " +
                          "Experienced in managing large-scale operations with precision, strategic insight, and powerful leadership. " +
                          "Capable of transforming weaknesses into strengths through persistent growth and mastery of system mechanics.",
                ImageUrl = "/img/jinwoo.jpg"
            },

            Contact = new Contact
            {
                Phone = new List<string> { "+82 444 777 9999" },
                Email = "jinwoo@huntersguild.kr",
                Address = "Seoul, South Korea",
                LinkedIn = "https://linkedin.com/in/sungjinwoo",
                GitHub = "https://github.com/shadowmonarchdev",
                Portfolio = "https://solo-leveling.system"
            },

            TechnicalSkills = new List<TechnicalSkill>
    {
        new TechnicalSkill
        {
            Category = "Combat & Field Operations",
            Skill1 = new List<string> { "Swordsmanship", "Shadow Extraction", "Tactical Combat" },
            Skill2 = new List<string> { "Gate Exploration", "Monster Raid Coordination" },
            Skill3 = new List<string> { "Solo Boss Elimination", "Dimensional Management" }
        },
        new TechnicalSkill
        {
            Category = "System & Magic Control",
            Skill1 = new List<string> { "System Programming", "Mana Control", "Summoning Protocols" },
            Skill2 = new List<string> { "Shadow Synchronization", "AI-assisted Combat Algorithms" },
            Skill3 = new List<string> { "Spatial Analysis", "Data Adaptation" }
        },
        new TechnicalSkill
        {
            Category = "Leadership & Team Management",
            Skill1 = new List<string> { "Command Strategy", "High-Pressure Decision Making", "Training & Mentoring" },
            Skill2 = new List<string> { "Cross-Guild Coordination", "Team Revival Operations" }
        },
        new TechnicalSkill
        {
            Category = "Technical Tools",
            Skill1 = new List<string> { "System API (Level-Up System)", "Portal Scanning Tools", "Shadow Archive DB" }
        }
    },

            Projects = new List<Project>
    {
        new Project
        {
            Name = "Shadow Legion Management System",
            Date = new DateTime(2024, 5, 1),
            Description = "Developed and deployed a scalable system to manage thousands of autonomous shadow entities. " +
                          "Integrated real-time command synchronization and dimensional deployment capabilities.",
            Link = "https://github.com/shadowmonarchdev/shadow-legion-system"
        },
        new Project
        {
            Name = "Gate Stabilization Program",
            Date = new DateTime(2023, 9, 15),
            Description = "Led an inter-guild initiative to neutralize unstable gates using advanced mana compression algorithms. " +
                          "Resulted in a 90% reduction in global portal disasters.",
            Link = "https://github.com/shadowmonarchdev/gate-stabilizer"
        }
    },

            ProfessionalExperience = new List<ProfessionalExperience>
    {
        new ProfessionalExperience
        {
            CompanyName = "Korean Hunters Association",
            Role = "S-Rank Hunter / Special Operations Leader",
            Duration = "2019 - Present",
            Details = new ProfessionalExperience_Details
            {
                Responsibilities = new List<string>
                {
                    "Lead high-risk gate expeditions and global emergency response missions.",
                    "Manage shadow-based combat units for strategic monster suppression.",
                    "Coordinate intelligence between guilds for cross-dimensional threats."
                },
                Achievements = new List<string>
                {
                    "Promoted from E-Rank to S-Rank through solo missions.",
                    "Neutralized multiple S-Rank and National-Level threats alone.",
                    "Recognized globally as the strongest hunter on Earth."
                }
            }
        },
        new ProfessionalExperience
        {
            CompanyName = "Ahjin Guild",
            Role = "Guild Master",
            Duration = "2020 - Present",
            Details = new ProfessionalExperience_Details
            {
                Responsibilities = new List<string>
                {
                    "Founded and managed Ahjin Guild with elite members for precision raids.",
                    "Oversee recruitment, mission execution, and tactical innovation.",
                    "Ensure operational secrecy while maintaining peak combat readiness."
                },
                Achievements = new List<string>
                {
                    "Completed over 150 high-level dungeon raids.",
                    "Zero casualty record for all guild missions.",
                    "Established international recognition for professionalism and power."
                }
            }
        }
    },

            Education = new List<Education>
    {
        new Education
        {
            Institution = "Seoul National Academy of Hunters",
            Degree = "Advanced Studies in Mana Control & Combat Systems",
            Duration = "2016 - 2018",
            Description = "Specialized in mana structure, gate theory, and tactical monster engagement."
        }
    },

            Certifications = new List<Certifications>
    {
        new Certifications
        {
            Name = "S-Rank Hunter License",
            Duration = "Lifetime",
            Courses = "High-Risk Dungeon Clearance, Monster Analysis, Emergency Protocols"
        },
        new Certifications
        {
            Name = "Dimensional Stabilization Expert",
            Duration = "2023 - Present",
            Courses = "Portal Physics, Shadow Integration, Rift Repair"
        }
    },

            Achievements = new Achievements
            {
                Items = new List<string>
        {
            "Achieved transformation into the Shadow Monarch, mastering shadow-based magic.",
            "Defeated Monarch-class entities and restored dimensional balance.",
            "Formed and led the strongest legion in human history."
        }
            },

            ResumeFooter = new ResumeFooter
            {
                ContactInfo = "For collaboration or dimensional consultation inquiries, contact via Hunters Association.",
                SocialMediaLinks = "LinkedIn | GitHub | Hunters Association Network"
            }
        };

    }
}
