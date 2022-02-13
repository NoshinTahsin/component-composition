using System;
using ClassLibraryResumeProvider;
using ClassLibraryInitialScreening;
using ClassLibraryFinalAssessment;

namespace RecruitmentSequentialComposition
{
    class RecruitmentInterface: IResumeProvider, IInitialScreening, IFinalAssessment
    {
        public string provideResume()
        {
            return "AllResumeList";
        }

        public string provideSelected(string all_resume_list)
        {
            return "InitiallySelectedResumes";
        }

        public string acceptanceList(string initially_selected_resume)
        {
            return "FinallySelectedCandidates";
        }




    }
}
