namespace KalmDownCSharp.Managers
{
    using System.Windows;
    using System.Windows.Media;

    internal interface ISettingManager
    {
        void ChangeSettings(string changeMinute, string changeSecond, Color? changeColor);

        Duration GetSettingDuration();
    }
}
