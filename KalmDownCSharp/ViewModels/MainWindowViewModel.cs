namespace KalmDownCSharp.ViewModels
{
    using KalmDownCSharp.Managers;
    using KalmDownCSharp.Models;
    using System.ComponentModel;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Media.Animation;

    internal class MainWindowViewModel : IMainWindowViewModel, INotifyPropertyChanged
    {
        private readonly ITimerManager timerManager;
        private readonly ISettingManager settingManager;
        private TimeGapModel gapModel;

        public TimeGapModel GapModel
        {
            get
            {
                return this.gapModel;
            }
            set
            {
                this.gapModel = value;
                this.OnPropertyChanged("Gap");
            }
        }

        public MainWindowViewModel(
            ITimerManager timerManager,
            ISettingManager settingManager)
        {
            this.gapModel = new TimeGapModel();

            this.timerManager = timerManager;
            this.settingManager = settingManager;

            this.timerManager.SetTimeGapObject(this.gapModel);
        }

        public Storyboard CreateCatStoryboard(Grid catGrid, PropertyPath propertyPath)
        {
            var from = new Thickness(10, 20, 0, 0);
            var to = new Thickness(250, 20, 0, 0);
            var animation = new ThicknessAnimation(from, to, this.settingManager.GetSettingDuration());

            Storyboard.SetTarget(animation, catGrid);
            Storyboard.SetTargetProperty(animation, propertyPath);

            var storyboard = new Storyboard();
            storyboard.Children.Add(animation);

            return storyboard;
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
