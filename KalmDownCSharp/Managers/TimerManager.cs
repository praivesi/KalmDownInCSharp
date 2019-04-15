namespace KalmDownCSharp.Managers
{
    using KalmDownCSharp.Models;
    using System;
    using System.Windows;
    using System.Windows.Threading;

    internal class TimerManager : ITimerManager
    {
        private readonly DispatcherTimer timer;

        private TimeGapModel gapModel;
        private TimeSpan currentGap;
        private DateTime deadline;

        public TimerManager()
        {
            // Create & Allocate Instances
            timer = new DispatcherTimer();

            deadline = DateTime.Now + new TimeSpan(0, 5, 0);

            // Set Timer
            timer.Tick += new EventHandler(kdTimer_Tick);
            timer.Interval = new TimeSpan(0, 0, 0, 0, 10); // 10 milliseconds
            timer.Start();
        }

        public void SetTimeGapObject(TimeGapModel gapModel) => this.gapModel = gapModel;

        private void kdTimer_Tick(object sender, EventArgs e)
        {
            if (this.gapModel == null)
            {
                MessageBox.Show("TimeGap 객체가 할당되어 있지 않습니다.");
                return;
            }

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


