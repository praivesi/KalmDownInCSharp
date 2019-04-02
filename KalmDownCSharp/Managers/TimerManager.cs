namespace KalmDownCSharp.Managers
{
    using KalmDownCSharp.Models;
    using System;
    using System.Windows.Threading;

    internal class TimerManager
    {
        private readonly DispatcherTimer timer;
        private readonly TimeGapModel gapModel;
        private readonly DateTime deadline;
        private TimeSpan currentGap;

        public TimerManager(TimeGapModel gapModel)
        {
            // Create & Allocate Instances
            timer = new DispatcherTimer();

            //deadline = DateTime.Now + new TimeSpan(0, 5, 0);
            deadline = DateTime.Now + new TimeSpan(0, 0, 10);
            this.gapModel = gapModel;

            // Set Timer
            timer.Tick += new EventHandler(kdTimer_Tick);
            timer.Interval = new TimeSpan(0, 0, 0, 0, 10); // 10 milliseconds
            timer.Start();
        }

        private void kdTimer_Tick(object sender, EventArgs e)
        {
            this.currentGap = this.deadline - DateTime.Now;

            if (this.currentGap <= TimeSpan.Zero)
            {
                timer.Stop();

                this.gapModel.GapMin = "0";
                this.gapModel.GapSec = "00";
                this.gapModel.GapMilli = "000";

            }
            else
            {
                this.gapModel.GapMin = this.currentGap.Minutes.ToString("0");
                this.gapModel.GapSec = this.currentGap.Seconds.ToString("00");
                this.gapModel.GapMilli = this.currentGap.Milliseconds.ToString("000");
            }
        }
    }
}


