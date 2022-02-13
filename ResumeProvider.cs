using System;

//created a c# class library
//interface for resume provider class
namespace ClassLibraryResumeProvider
{
    public class ResumeProvider
    {
        private IResumeProvider rp;
        public ResumeProvider(IResumeProvider rp)
        {
            this.rp = rp;
        }
        public string showrequired()
        {
            return this.rp.provideResume();
        }
        public string provideResume()
        {
            String allResumeList = "All Collected Resumes";
            Console.WriteLine("Providing list of "+allResumeList+"...");
            return allResumeList;

        }

    }
}