using System;

namespace ClassLibraryInitialScreening
{
    public class InitialScreening
    {
        private IInitialScreening init_screen;
        public InitialScreening(IInitialScreening init_screen)
        {
            this.init_screen = init_screen;
        }
        public string showrequired(string allresumelist)
        {
            return this.init_screen.provideSelected(allresumelist);
        }
        public string provideSelected(string AllResumeList)
        {
            String selectedResumeList = "Selected Resume List";
            Console.WriteLine("Providing selected resume list after initial screening of the " + AllResumeList+"...");
            return selectedResumeList;
        }
    }
}