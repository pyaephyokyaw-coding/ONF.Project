using ONF.Resume.Pages.Resume;

namespace ONF.Resume.Helper;

public class CommonFunction
{
    public CommonFunction()
    {
    }

    public static ResumeModel GetResumeModelByName(string resumeName)
    {
        var resumeModel =
            DeathNoteResumeData.GetSampleData().PersonalOverview?.Name == resumeName ? DeathNoteResumeData.GetSampleData() :
            DemonSlayerResumeData.GetSampleData().PersonalOverview?.Name == resumeName ? DemonSlayerResumeData.GetSampleData() :
            GojoResumeData.GetSampleData().PersonalOverview?.Name == resumeName ? GojoResumeData.GetSampleData() :
            LuffyResumeData.GetSampleData().PersonalOverview?.Name == resumeName ? LuffyResumeData.GetSampleData() :
            NarutoResumeData.GetSampleData().PersonalOverview?.Name == resumeName ? NarutoResumeData.GetSampleData() :
            SaitamaResumeData.GetSampleData().PersonalOverview?.Name == resumeName ? SaitamaResumeData.GetSampleData() :
            SonGokuResumeData.GetSampleData().PersonalOverview?.Name == resumeName ? SonGokuResumeData.GetSampleData() :
            SungJinwooResumeData.GetSampleData();
        ;

        return resumeModel;
    }

    public static ResumeModel GetResumeModelByCode(string resumeCode)
    {
        var resumeModel =
            DeathNoteResumeData.GetSampleData().PersonalOverview?.ResumeCode == resumeCode ? DeathNoteResumeData.GetSampleData() :
            DemonSlayerResumeData.GetSampleData().PersonalOverview?.ResumeCode == resumeCode ? DemonSlayerResumeData.GetSampleData() :
            GojoResumeData.GetSampleData().PersonalOverview?.ResumeCode == resumeCode ? GojoResumeData.GetSampleData() :
            LuffyResumeData.GetSampleData().PersonalOverview?.ResumeCode == resumeCode ? LuffyResumeData.GetSampleData() :
            NarutoResumeData.GetSampleData().PersonalOverview?.ResumeCode == resumeCode ? NarutoResumeData.GetSampleData() :
            SaitamaResumeData.GetSampleData().PersonalOverview?.ResumeCode == resumeCode ? SaitamaResumeData.GetSampleData() :
            SonGokuResumeData.GetSampleData().PersonalOverview?.ResumeCode == resumeCode ? SonGokuResumeData.GetSampleData() :
            SungJinwooResumeData.GetSampleData();
        ;

        return resumeModel;
    }

    public static List<ResumeModel> GetAllSampleResumeModels()
    {
        return new List<ResumeModel>
        {
            NarutoResumeData.GetSampleData(),
            LuffyResumeData.GetSampleData(),
            GojoResumeData.GetSampleData(),
            DemonSlayerResumeData.GetSampleData(),
            SaitamaResumeData.GetSampleData(),
            DeathNoteResumeData.GetSampleData(),
            SonGokuResumeData.GetSampleData(),
            SungJinwooResumeData.GetSampleData()
        };
    }

    public static List<PersonalOverview> personalOverviews = GetAllSampleResumeModels().Select(r => r.PersonalOverview).ToList();
}
