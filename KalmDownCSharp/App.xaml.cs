namespace KalmDownCSharp
{
    using KalmDownCSharp.DI;
    using Ninject;
    using System.Windows;

    /// <summary>
    /// App.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class App : Application
    {
        private IKernel container;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            this.container = new StandardKernel();
            this.container.Load(new KalmDownModule());

            var mainWindow = this.container.Get<MainWindow>();

            mainWindow.Show();
        }
    }
}
