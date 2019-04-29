namespace KalmDownCSharp
{
    using KalmDownCSharp.ViewModels;
    using System;
    using System.Windows;

    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IMainWindowViewModel vm;
        private readonly ISettingWindowViewModel settingWindowVM;

        public MainWindow(
            IMainWindowViewModel vm,
            ISettingWindowViewModel settingWindowVM)
        {
            InitializeComponent();

            this.vm = vm;
            this.settingWindowVM = settingWindowVM;

            this.DataContext = vm;

            this.vm.CreateCatStoryboard(this.cat, new PropertyPath(MarginProperty)).Begin();
        }

        private void MainWindow_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e) => this.DragMove();

        private void exitBtn_Click(object sender, RoutedEventArgs e) => Environment.Exit(0);
    }
}
