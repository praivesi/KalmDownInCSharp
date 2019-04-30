namespace KalmDownCSharp.Managers
{
    using KalmDownCSharp.Models;

    internal interface ITimerManager
    {
        void SetTimeGapObject(TimeGapModel gapModel);

        void SetDeadlineFromSettingModel(SettingModel settingModel);
    }
}
