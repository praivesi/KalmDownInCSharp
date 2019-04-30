namespace KalmDownCSharp.ViewModels
{
    using KalmDownCSharp.Commands;
    using KalmDownCSharp.Infrastructure;
    using KalmDownCSharp.Managers;
    using KalmDownCSharp.Models;
    using KalmDownCSharp.UIs;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;
    using System.Windows.Media.Animation;

    internal class MainWindowViewModel : ViewModelBase, IMainWindowViewModel
    {
        private readonly ITimerManager timerManager;
        private readonly ISettingManager settingManager;
        private TimeGapModel gapModel;

        private ICommand showSettingWindowCommand;

        private readonly ISettingWindowViewModel settingWindowVM;
        private readonly IMediator mediator;

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

        public ICommand ShowSettingWindowCommand
        {
            get
            {
                return this.showSettingWindowCommand;
            }
            set
            {
                this.showSettingWindowCommand = value;
            }
        }

        public MainWindowViewModel(
            ITimerManager timerManager,
            ISettingManager settingManager,
            ISettingWindowViewModel settingWindowVM,
            IMediator mediator)
        {
            this.gapModel = new TimeGapModel();

            this.timerManager = timerManager;
            this.settingManager = settingManager;

            this.timerManager.SetTimeGapObject(this.gapModel);

            this.settingWindowVM = settingWindowVM;
            this.mediator = mediator;

            this.showSettingWindowCommand = new BaseCommand(this.ShowSettingWindow);

            this.RegisterEvents();
        }

        private void RegisterEvents()
        {
            this.mediator.Register("SettingChanged", this.OnSettingChanged);
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

        public void ShowSettingWindow(object obj)
        {
            var settingsWindow = new SettingWindow(this.settingWindowVM);

            settingsWindow.ShowDialog();
        }

        public void OnSettingChanged(object parameter)
        {
            this.timerManager.SetDeadlineFromSettingModel(this.settingManager.Settings);
        }
    }
}
