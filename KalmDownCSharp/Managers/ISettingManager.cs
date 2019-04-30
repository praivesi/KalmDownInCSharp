namespace KalmDownCSharp.Managers
{
    using KalmDownCSharp.Models;
    using System.Windows;
    using System.Windows.Media;

    internal interface ISettingManager
    {
        SettingModel Settings { get; }

        void ChangeSettings(string changeMinute, string changeSecond, Color? changeColor);

        Duration GetSettingDuration();
    }
}
