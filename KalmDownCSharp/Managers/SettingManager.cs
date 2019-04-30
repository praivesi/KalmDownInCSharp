namespace KalmDownCSharp.Managers
{
    using KalmDownCSharp.Models;
    using System;
    using System.Windows;
    using System.Windows.Media;

    internal class SettingManager : ISettingManager
    {
        public SettingModel Settings { get; private set; }

        public SettingManager() {
            this.Settings = new SettingModel();
        }

        public void ChangeSettings(string changeMinute, string changeSecond, Color? changeColor)
        {
            this.Settings.SettingMinute = changeMinute;
            this.Settings.SettingSecond = changeSecond;
            this.Settings.SettingColor = changeColor;
        }

        public Duration GetSettingDuration()
            => new Duration(new TimeSpan(0, Int32.Parse(this.Settings.SettingMinute), Int32.Parse(this.Settings.SettingSecond)));
    }
}
