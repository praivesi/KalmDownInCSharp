namespace KalmDownCSharp.Models
{
    using System.ComponentModel;
    using System.Windows.Media;

    internal class SettingModel : INotifyPropertyChanged
    {
        public string SettingMinute
        {
            get { return this.settingMinute; }
            set
            {
                this.settingMinute = value;
                OnPropertyChanged("SettingMinute");
            }
        }
        public string SettingSecond
        {
            get { return this.settingSecond; }
            set
            {
                this.settingSecond = value;
                OnPropertyChanged("SettingSecond");
            }
        }
        public Color? SettingColor
        {
            get { return this.settingColor; }
            set
            {
                this.settingColor = value;
                OnPropertyChanged("SettingColor");
            }
        }

        private string settingMinute;
        private string settingSecond;
        private Color? settingColor;

        public event PropertyChangedEventHandler PropertyChanged;

        public SettingModel()
        {
            this.SettingMinute = "5";
            this.SettingSecond = "0";
            this.SettingColor = Colors.White;
        }

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
