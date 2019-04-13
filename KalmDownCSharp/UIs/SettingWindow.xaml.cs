namespace KalmDownCSharp.UIs
{
    using KalmDownCSharp.ViewModels;
    using System.Collections.ObjectModel;
    using System.Windows;

    /// <summary>
    /// SettingWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class SettingWindow : Window
    {
        private readonly ISettingWindowViewModel vm;

        private ObservableCollection<string> minuteCbItems;
        private ObservableCollection<string> secondCbItems;

        public SettingWindow(ISettingWindowViewModel vm)
        {
            InitializeComponent();

            this.vm = vm;
            this.minuteCbItems = new ObservableCollection<string>();
            this.secondCbItems = new ObservableCollection<string>();

            for (int i = 0; i < 60; i++)
            {
                minuteCbItems.Add(i.ToString());
                secondCbItems.Add(i.ToString());
            }

            this.cbMin.ItemsSource = minuteCbItems;
            this.cbSec.ItemsSource = secondCbItems;
        }

        private void confirmBtn_Click(object sender, RoutedEventArgs e)
        {
            if (this.cbMin.SelectedItem == null || this.cbSec.SelectedItem == null || this.clrPicker.SelectedColor == null)
                MessageBox.Show("모든 칸을 채워주세요 : (");
            else
                this.vm.Set(this.cbMin.SelectedItem?.ToString(), this.cbSec.SelectedItem?.ToString(), this.clrPicker.SelectedColor);
        }
    }
}
