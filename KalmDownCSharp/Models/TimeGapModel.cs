namespace KalmDownCSharp.Models
{
    using System.ComponentModel;

    internal class TimeGapModel : INotifyPropertyChanged
    {
        public string GapMin
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

        public string GapSec
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

        public string GapMilli
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

        private string gapMin;
        private string gapSec;
        private string gapMilli;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
