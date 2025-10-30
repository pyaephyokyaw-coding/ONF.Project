namespace ONF.Resume.Pages.Resume;

public class DeathNoteResumeData
{
    public static ResumeModel GetSampleData()
    {
        return new ResumeModel
        {
            PersonalOverview = new PersonalOverview
            {
                Title = "World-Class Detective / Cybersecurity Analyst",
                Name = "L Lawliet",
                Summary = "Highly analytical and reclusive investigator known for solving globally complex cases. " +
                          "Exceptional in logic deduction, data analysis, and behavioral pattern recognition. " +
                          "Prefers minimal sleep, excessive caffeine, and absolute truth. Skilled in cyber forensics and network security.",
                ImageUrl = "img/deathnote.jpg"
            },

            Contact = new Contact
            {
                Phone = new List<string> { "+81 111 222 3333" },
                Email = "lawliet.l@investigations.jp",
                Address = "Confidential – Tokyo, Japan",
                LinkedIn = "https://linkedin.com/in/l-lawliet",
                GitHub = "https://github.com/worlddetectiveL",
                Portfolio = "https://l-investigations.net"
            },

            TechnicalSkills = new List<TechnicalSkill>
    {
        new TechnicalSkill
        {
            Category = "Cybersecurity & Forensics",
            Skill1 = new List<string> { "Digital Forensics", "Ethical Hacking", "Malware Analysis" },
            Skill2 = new List<string> { "Network Security", "Encryption Algorithms", "Penetration Testing" },
            Skill3 = new List<string> { "Incident Response", "Threat Intelligence" }
        },
        new TechnicalSkill
        {
            Category = "Programming & Data Science",
            Skill1 = new List<string> { "Python", "C#", "SQL" },
            Skill2 = new List<string> { "Machine Learning", "Data Mining", "Pattern Recognition" },
            Skill3 = new List<string> { "Pandas", "TensorFlow", "Power BI" }
        },
        new TechnicalSkill
        {
            Category = "Tools & Frameworks",
            Skill1 = new List<string> { "Wireshark", "Kali Linux", "Burp Suite" },
            Skill2 = new List<string> { "Splunk", "ELK Stack", "Docker" }
        },
        new TechnicalSkill
        {
            Category = "Soft Skills",
            Skill1 = new List<string> { "Analytical Thinking", "Observation", "Crisis Management" },
            Skill2 = new List<string> { "Leadership under anonymity", "Strategic Decision Making" }
        }
    },

            Projects = new List<Project>
    {
        new Project
        {
            Name = "Global Criminal Profiling System",
            Date = new DateTime(2023, 3, 10),
            Description = "Developed an AI-driven system that analyzes behavioral and digital footprints " +
                          "to predict and track high-profile criminals globally. Used deep learning models " +
                          "to process linguistic patterns, social media data, and network traces.",
            Link = "https://github.com/worlddetectiveL/criminal-profiling"
        },
        new Project
        {
            Name = "Kira Detection Initiative",
            Date = new DateTime(2024, 9, 5),
            Description = "Led an international cybersecurity investigation involving abnormal mortality data leaks. " +
                          "Designed data correlation algorithms and forensic pipelines to trace encrypted transmissions.",
            Link = "https://github.com/worlddetectiveL/kira-detection"
        }
    },

            ProfessionalExperience = new List<ProfessionalExperience>
    {
        new ProfessionalExperience
        {
            CompanyName = "International Criminal Police Organization (ICPO)",
            Role = "Cyber Intelligence Consultant",
            Duration = "2018 - Present",
            Details = new ProfessionalExperience_Details
            {
                Responsibilities = new List<string>
                {
                    "Lead confidential digital crime investigations across multiple jurisdictions.",
                    "Analyze massive datasets to detect anomalies and threat actors.",
                    "Collaborate with law enforcement agencies to build predictive security models."
                },
                Achievements = new List<string>
                {
                    "Solved over 500 international cybercrime cases.",
                    "Developed AI-assisted crime pattern detection tools.",
                    "Reduced digital investigation time by 40% through automation."
                }
            }
        },
        new ProfessionalExperience
        {
            CompanyName = "Wammy’s House Intelligence Division",
            Role = "Chief Researcher",
            Duration = "2010 - 2018",
            Details = new ProfessionalExperience_Details
            {
                Responsibilities = new List<string>
                {
                    "Mentored gifted analysts in computational forensics and logical deduction.",
                    "Designed high-security data systems for anonymous information exchange.",
                    "Conducted advanced encryption and decryption research."
                },
                Achievements = new List<string>
                {
                    "Built encrypted communication protocols still in use by global agencies.",
                    "Trained next-generation analysts including Near and Mello.",
                    "Recognized as the world's top independent investigator."
                }
            }
        }
    },

            Education = new List<Education>
    {
        new Education
        {
            Institution = "Wammy’s House Academy for the Gifted",
            Degree = "Advanced Degree in Criminal Psychology & Computer Science",
            Duration = "2005 - 2010",
            Description = "Focused on applied logic, artificial intelligence, and behavioral analytics. Graduated with top distinction."
        }
    },

            Certifications = new List<Certifications>
    {
        new Certifications
        {
            Name = "Certified Ethical Hacker (CEH)",
            Duration = "2020 - Present",
            Courses = "Penetration Testing, Network Vulnerability, Exploit Development"
        },
        new Certifications
        {
            Name = "CISSP – Certified Information Systems Security Professional",
            Duration = "2022 - Present",
            Courses = "Risk Management, Security Architecture, Cryptography"
        }
    },

            Achievements = new Achievements
            {
                Items = new List<string>
        {
            "Successfully identified and tracked the global 'Kira' phenomenon.",
            "Ranked #1 among international detectives for seven consecutive years.",
            "Developed an AI-assisted reasoning model used by global security agencies."
        }
            },

            ResumeFooter = new ResumeFooter
            {
                ContactInfo = "For confidential inquiries only — identity protected.",
                SocialMediaLinks = "LinkedIn | GitHub | ICPO Network"
            }
        };

    }
}
