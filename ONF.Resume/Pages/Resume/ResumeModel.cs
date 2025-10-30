namespace ONF.Resume.Pages.Resume;

public class ResumeModel
{
    public PersonalOverview? PersonalOverview { get; set; }
    public Contact? Contact { get; set; }
    public List<TechnicalSkill>? TechnicalSkills { get; set; }
    public List<Project>? Projects { get; set; }
    public List<ProfessionalExperience>? ProfessionalExperience { get; set; }
    public List<Education>? Education { get; set; }
    public List<Certifications>? Certifications { get; set; }
    public Achievements? Achievements { get; set; }
    public ResumeFooter? ResumeFooter { get; set; }
    public ColorSetting? ColorSetting { get; set; }
}

public class PersonalOverview
{
    private string _resumeCode;
    private string _resumeName;
    public string ResumeCode => _resumeCode;
    public required string Title { get; set; }
    public required string Name
    {
        get => _resumeName;
        set {
            _resumeName = value;
            _resumeCode = value.Replace(" ", "").ToLower() + "_" + DateTime.Now.ToString("yyyyMMddHHmmss");
        }
    }
    public required string Summary { get; set; }
    public string? ImageUrl { get; set; }
}

public class Contact
{
    public List<string>? Phone { get; set; }
    public string? Email { get; set; }
    public string? Address { get; set; }
    public string? LinkedIn { get; set; }
    public string? GitHub { get; set; }
    public string? Portfolio { get; set; }
}

public class TechnicalSkill
{
    public string? Category { get; set; }
    public List<string>? Skill1 { get; set; }
    public List<string>? Skill2 { get; set; }
    public List<string>? Skill3 { get; set; }
    public List<string>? Skill4 { get; set; }
    public List<string>? Skill5 { get; set; }

}

public class Project
{
    public string? Name { get; set; }
    public DateTime? Date { get; set; }
    public string? Description { get; set; }
    public string? Link { get; set; }
}

public class ProfessionalExperience
{
    public string? CompanyName { get; set; }
    public string? Role { get; set; }
    public string? Duration { get; set; }
    public ProfessionalExperience_Details? Details { get; set; }
}

public class ProfessionalExperience_Details
{
    public List<string>? Responsibilities { get; set; }
    public List<string>? Achievements { get; set; }
}

public class Education
{
    public string? Institution { get; set; }
    public string? Degree { get; set; }
    public string? Duration { get; set; }
    public string? Description { get; set; }
}

public class Certifications
{
    public string? Name { get; set; }
    public string? Duration { get; set; }
    public string? Courses { get; set; }
}

public class Achievements
{
    public List<string>? Items { get; set; }
}

public class ResumeFooter
{
    public string? ContactInfo { get; set; }
    public string? SocialMediaLinks { get; set; }
}

public class ColorSetting
{
    public string SideBgColor { get; set; } = "#2E70A3";
    public string SideTextColor { get; set; } = "#FFFFFF";
    public string MainBgColor { get; set; } = "#FFFFFF";
    public string MainTextColor { get; set; } = "#000000";
}
