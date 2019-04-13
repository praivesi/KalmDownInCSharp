namespace KalmDownCSharp.ViewModels
{
    using KalmDownCSharp.Managers;
    using System.Windows.Media;

    internal class SettingWindowViewModel : ISettingWindowViewModel
    {
        private readonly ISettingManager settingManager;

        public SettingWindowViewModel(ISettingManager settingManager) => this.settingManager = settingManager;

        public void Set(string min, string sec, Color? color) => this.settingManager.ChangeSettings(min, sec, color);
    }
}
