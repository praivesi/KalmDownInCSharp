namespace KalmDownCSharp.ViewModels
{
    using KalmDownCSharp.Managers;
    using KalmDownCSharp.Models;
    using System.ComponentModel;

    internal class MainViewModel : INotifyPropertyChanged
    {
        private readonly TimerManager timerManager;
        private readonly TimeGap gap;

        public TimeGap Gap
        {
            get
            {
                return this.gap;
            }
            set
            {
                this.OnPropertyChanged("Gap");
            }
        }

        public MainViewModel()
        {
            this.gap = new TimeGap();
            this.timerManager = new TimerManager(this.gap);
        }

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
