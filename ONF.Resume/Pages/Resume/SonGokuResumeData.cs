namespace ONF.Resume.Pages.Resume;

public class SonGokuResumeData
{
    public static ResumeModel GetSampleData()
    {
        return new ResumeModel
        {
            PersonalOverview = new PersonalOverview
            {
                Title = "Martial Arts Master / Energy Specialist / Motivational Coach",
                Name = "Son Goku (Kakarot)",
                Summary = "Passionate and dedicated martial artist with decades of experience in high-intensity combat training, " +
                          "energy control, and personal development. Known for unwavering determination, positive attitude, " +
                          "and ability to inspire others to reach their full potential. Skilled in teaching advanced combat " +
                          "techniques, meditation, and team coordination.",
                ImageUrl = "img/goku.jpg"
            },

            Contact = new Contact
            {
                Phone = new List<string> { "+81 555 777 9999" },
                Email = "son.goku@capsulecorp.jp",
                Address = "Mount Paozu, Earth",
                LinkedIn = "https://linkedin.com/in/songoku",
                GitHub = "https://github.com/goku-training",
                Portfolio = "https://gokumindbodypower.com"
            },

            TechnicalSkills = new List<TechnicalSkill>
    {
        new TechnicalSkill
        {
            Category = "Martial Arts & Physical Training",
            Skill1 = new List<string> { "Kame Style Martial Arts", "Ki Control", "Combat Strategy" },
            Skill2 = new List<string> { "Ultra Instinct Mastery", "Agility & Reflex Training" },
            Skill3 = new List<string> { "Strength Conditioning", "Endurance Coaching" }
        },
        new TechnicalSkill
        {
            Category = "Energy & Meditation Techniques",
            Skill1 = new List<string> { "Kamehameha Wave", "Spirit Bomb (Genki Dama)" },
            Skill2 = new List<string> { "Instant Transmission", "Aura Control" },
            Skill3 = new List<string> { "Mind-Body Synchronization" }
        },
        new TechnicalSkill
        {
            Category = "Teaching & Mentoring",
            Skill1 = new List<string> { "Student Mentorship", "Motivational Speaking", "Team Leadership" },
            Skill2 = new List<string> { "Discipline Training", "Conflict Resolution" }
        },
        new TechnicalSkill
        {
            Category = "Other Skills",
            Skill1 = new List<string> { "Farming", "Cooking (basic)", "Resilience", "Cross-Planet Survival" }
        }
    },

            Projects = new List<Project>
    {
        new Project
        {
            Name = "Universe Survival Training Program",
            Date = new DateTime(2024, 2, 20),
            Description = "Designed and led a multi-universe combat training program to enhance strength, teamwork, and " +
                          "survival skills among elite fighters. Resulted in successful defense of Universe 7.",
            Link = "https://github.com/goku-training/universe-survival-program"
        },
        new Project
        {
            Name = "Ultra Instinct Control System",
            Date = new DateTime(2023, 8, 10),
            Description = "Developed a self-awareness and reflex optimization system to trigger Ultra Instinct state " +
                          "under pressure. Combined meditation, ki flow analysis, and combat AI simulation.",
            Link = "https://github.com/goku-training/ultra-instinct-control"
        }
    },

            ProfessionalExperience = new List<ProfessionalExperience>
    {
        new ProfessionalExperience
        {
            CompanyName = "Z Fighters",
            Role = "Lead Combat Specialist",
            Duration = "Age 761 - Present",
            Details = new ProfessionalExperience_Details
            {
                Responsibilities = new List<string>
                {
                    "Lead combat strategist and first responder to planetary and galactic threats.",
                    "Train and coordinate Z Fighters including Vegeta, Gohan, and Piccolo.",
                    "Analyze opponents’ abilities and develop counter-strategies."
                },
                Achievements = new List<string>
                {
                    "Defeated multiple universal-level threats (Frieza, Cell, Buu, Jiren).",
                    "Achieved Ultra Instinct transformation, surpassing mortal limits.",
                    "Maintained Earth’s safety record at 99.9% for over two decades."
                }
            }
        },
        new ProfessionalExperience
        {
            CompanyName = "Kame House Martial Arts Dojo",
            Role = "Martial Arts Instructor",
            Duration = "Age 750 - 761",
            Details = new ProfessionalExperience_Details
            {
                Responsibilities = new List<string>
                {
                    "Trained under Master Roshi and passed down traditional martial arts to new students.",
                    "Demonstrated energy control and self-discipline techniques.",
                    "Organized world martial arts tournaments and combat workshops."
                },
                Achievements = new List<string>
                {
                    "Won multiple World Martial Arts Tournaments.",
                    "Helped establish new ki training curriculum for young fighters.",
                    "Recognized as the strongest martial artist on Earth."
                }
            }
        }
    },

            Education = new List<Education>
    {
        new Education
        {
            Institution = "Kame School of Martial Arts",
            Degree = "Master Certification in Ki & Martial Arts",
            Duration = "Age 750 - 755",
            Description = "Studied under Master Roshi focusing on discipline, energy balance, and combat philosophy."
        },
        new Education
        {
            Institution = "Whis Advanced Training Academy",
            Degree = "Divine Combat Techniques",
            Duration = "Age 780 - 785",
            Description = "Trained under Whis to refine energy control and master Ultra Instinct at a cosmic level."
        }
    },

            Certifications = new List<Certifications>
    {
        new Certifications
        {
            Name = "Martial Arts Grandmaster Certification",
            Duration = "Lifetime",
            Courses = "Kamehameha Wave, Instant Transmission, Energy Efficiency"
        },
        new Certifications
        {
            Name = "Intergalactic Tournament Winner",
            Duration = "Multiple Years",
            Courses = "Universe 6–7 Battle, Tournament of Power"
        }
    },

            Achievements = new Achievements
            {
                Items = new List<string>
        {
            "Achieved Super Saiyan, Super Saiyan Blue, and Ultra Instinct transformations.",
            "Defeated the most powerful beings across universes.",
            "Inspired multiple generations of warriors through leadership and humility."
        }
            },

            ResumeFooter = new ResumeFooter
            {
                ContactInfo = "For training collaborations or galactic defense missions, contact Capsule Corp HR.",
                SocialMediaLinks = "LinkedIn | GitHub | Capsule Network"
            }
        };

    }
}
