namespace KalmDownCSharp.Managers
{
    using KalmDownCSharp.Models;
    using System;
    using System.Windows.Threading;

    internal class TimerManager
    {
        private readonly DispatcherTimer kdTimer;
        private readonly DateTime deadline;
        private readonly TimeGap gap;

        public TimerManager(TimeGap gap)
        {
            this.gap = gap;

            deadline = DateTime.Now + new TimeSpan(0, 5, 0);

            kdTimer = new DispatcherTimer();
            kdTimer.Tick += new EventHandler(kdTimer_Tick);
            kdTimer.Interval = new TimeSpan(0, 0, 0, 0, 10); // 10 milliseconds

            kdTimer.Start();
        }

        private void kdTimer_Tick(object sender, EventArgs e)
        {
            var gapTime = this.deadline - DateTime.Now;

            this.gap.GapMin = gapTime.Minutes;
            this.gap.GapSec = gapTime.Seconds;
            this.gap.GapMilli = gapTime.Milliseconds;
        }
    }
}


