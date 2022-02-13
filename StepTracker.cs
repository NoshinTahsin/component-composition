using System;

namespace ClassLibraryStepTracker
{
    public class StepTracker
    {
        private IStepTracker st;
        public StepTracker(IStepTracker st)
        {
            this.st = st;
        }
        public string showrequired()
        {
            return this.st.trackStep();
        }
        public string trackStep()
        {
            return "Tracking Steps";
        }
    }
}