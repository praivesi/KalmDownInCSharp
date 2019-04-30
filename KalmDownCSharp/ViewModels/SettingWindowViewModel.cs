namespace KalmDownCSharp.ViewModels
{
    using KalmDownCSharp.Infrastructure;
    using KalmDownCSharp.Managers;
    using System.Windows.Media;

    internal class SettingWindowViewModel : ViewModelBase, ISettingWindowViewModel
    {
        private readonly ISettingManager settingManager;
        private readonly IMediator mediator;

        public SettingWindowViewModel(
            ISettingManager settingManager,
            IMediator mediator)
        {
            this.settingManager = settingManager;
            this.mediator = mediator;
        }

        public void Set(string min, string sec, Color? color)
        {
            this.settingManager.ChangeSettings(min, sec, color);
            this.mediator.NotifyColleagues("SettingChanged", null);
        }
    }
}
