﻿namespace KalmDownCSharp.Managers
{
    using KalmDownCSharp.Models;
    using System.Windows;
    using System.Windows.Media;

    internal class SettingManager
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

            MessageBox.Show("SettingMinute = " + this.Settings.SettingMinute + " / SettingSecond = " + this.Settings.SettingSecond + " / SettingColor = " + this.Settings.SettingColor);
        }
    }
}