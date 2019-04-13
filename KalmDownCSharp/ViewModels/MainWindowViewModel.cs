namespace KalmDownCSharp.ViewModels
{
    using KalmDownCSharp.Managers;
    using KalmDownCSharp.Models;
    using System.ComponentModel;

    internal class MainWindowViewModel : IMainWindowViewModel, INotifyPropertyChanged
    {
        private readonly ITimerManager timerManager;
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

        public MainWindowViewModel(ITimerManager timerManager)
        {
            this.gapModel = new TimeGapModel();

            this.timerManager = timerManager;
            this.timerManager.SetTimeGapObject(this.gapModel);
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
