namespace KalmDownCSharp
{
    using KalmDownCSharp.UIs;
    using KalmDownCSharp.ViewModels;
    using System;
    using System.Windows;

    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ISettingWindowViewModel settingWindowVM;

        public MainWindow(
            ISettingWindowViewModel settingWindowVM,
            IMainWindowViewModel mainWindowVM)
        {
            InitializeComponent();

            this.settingWindowVM = settingWindowVM;

            this.DataContext = mainWindowVM;
        }

        private void MainWindow_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void settingsBtn_ButtonClick(object sender, RoutedEventArgs e)
        {
            var settingsWindow = new SettingWindow(this.settingWindowVM);

            settingsWindow.ShowDialog();
        }

        private void exitBtn_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
