using System;

namespace ClassLibrarySleepTracker
{
    public class SleepTracker
    {
        private ISleepTracker st;
        public SleepTracker(ISleepTracker st)
        {
            this.st = st;
        }
        public string showrequired()
        {
            return this.st.trackSleep();
        }
        public string trackSleep()
        {
            return "Tracking Sleep";
        }
    }
}
