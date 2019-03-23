namespace KalmDownCSharp.Models
{
    using System.ComponentModel;

    internal class TimeGap : INotifyPropertyChanged
    {
        public int GapMin
        {
            get
            {
                return this.gapMin;
            }
            set
            {
                this.gapMin = value;

                this.OnPropertyChanged("GapMin");
            }
        }

        public int GapSec
        {
            get
            {
                return this.gapSec;
            }
            set
            {
                this.gapSec = value;

                this.OnPropertyChanged("GapSec");
            }
        }

        public int GapMilli
        {
            get
            {
                return this.gapMilli;
            }
            set
            {
                this.gapMilli = value;
                this.OnPropertyChanged("GapMilli");
            }
        }

        private int gapMin;
        private int gapSec;
        private int gapMilli;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
