using System;
using ClassLibraryResumeProvider;
using ClassLibraryInitialScreening;
using ClassLibraryFinalAssessment;

namespace RecruitmentSequentialComposition
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new RecruitmentInterface();
            var resume_provider = new ResumeProvider(x);

            Console.WriteLine("Demonstrating Sequential Component Composition\n");

            string allResumeList = resume_provider.showrequired();
            Console.WriteLine("Getting "+allResumeList+"...");

            var initial_screening = new InitialScreening(x);
            string selectedResumeList = initial_screening.showrequired(allResumeList);
            Console.WriteLine("Getting " + selectedResumeList + "...");

            var final_assessment = new FinalAssessment(x);
            Console.WriteLine("Getting " + final_assessment.showrequired(selectedResumeList) + "...");

            /*IResumeProvider resumeProvider = new ResumeProvider();
             IInitialScreening initialScreening = new InitialScreening();
             IFinalAssessment finalAssessment = new FinalAssessment();

             Console.WriteLine("Demonstrating Sequential Component Composition\n");

             String allResumeList = resumeProvider.provideResume();
             Console.WriteLine("<"+allResumeList+"> returned\n");
             String selectedResumeList = initialScreening.provideSelected(allResumeList);
             Console.WriteLine("<"+selectedResumeList + "> returned\n");
             String finalAcceptanceList = finalAssessment.acceptanceList(selectedResumeList);
             Console.WriteLine("<"+finalAcceptanceList + "> returned\n");*/

        }
    }
}
