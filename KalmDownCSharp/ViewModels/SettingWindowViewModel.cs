namespace KalmDownCSharp.ViewModels
{
    using KalmDownCSharp.Managers;
    using System.Windows.Media;

    internal class SettingWindowViewModel
    {
        private SettingManager settingManager;

        public SettingWindowViewModel()
        {
            this.settingManager = new SettingManager();
        }

        public void Set(string min, string sec, Color? color)
        {
            this.settingManager.ChangeSettings(min, sec, color);
        }
    }
}
