using System;
using ClassLibrarySleepTracker;
using ClassLibraryStepTracker;

namespace FitnessTrackerApp
{
    class FitnessTracker
    {
        static void Main(string[] args)
        {
            var ftc1 = new FitnessTrackerClass();

            var sleep_tracker_component = new SleepTracker(ftc1);
            Console.WriteLine(sleep_tracker_component.showrequired());

            var ftc2 = new FitnessTrackerClass();

            var step_tracker_component = new StepTracker(ftc2);
            Console.WriteLine(step_tracker_component.showrequired());
        }
    }
}
