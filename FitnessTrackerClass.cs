using System;
using ClassLibrarySleepTracker;
using ClassLibraryStepTracker;

namespace FitnessTrackerApp
{
    class FitnessTrackerClass : ISleepTracker, IStepTracker
    {

        public string trackSleep()
        {
            return "Tracking Sleep...";
        }
        public string trackStep()
        {
            return "Tracking Steps...";
        }


    }
}
