using System;

namespace ClassLibraryFinalAssessment
{
    public class FinalAssessment
    {
        private IFinalAssessment fa;
        public FinalAssessment(IFinalAssessment fa)
        {
            this.fa = fa;
        }
        public string showrequired(string selectedresumelist)
        {
            return this.fa.acceptanceList(selectedresumelist);
        }
        public string acceptanceList(string selectedResumeList)
        {
            string acceptedResumeList = "Final Accepted Resume List";
            Console.WriteLine("Providing acceptance list after final assessment of the "+selectedResumeList+"...");
            return acceptedResumeList;
        }
    }
}
