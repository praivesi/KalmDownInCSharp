namespace KalmDownCSharp.ViewModels
{
    using KalmDownCSharp.Managers;
    using KalmDownCSharp.Models;
    using System.ComponentModel;

    internal class MainViewModel : INotifyPropertyChanged
    {
        private readonly TimerManager timerManager;
        private readonly TimeGapModel gapModel;

        public TimeGapModel GapModel
        {
            get
            {
                return this.gapModel;
            }
            set
            {
                this.OnPropertyChanged("Gap");
            }
        }

        public MainViewModel()
        {
            this.gapModel = new TimeGapModel();
            this.timerManager = new TimerManager(this.gapModel);
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
