namespace KalmDownCSharp.DI
{
    using KalmDownCSharp.Infrastructure;
    using KalmDownCSharp.Managers;
    using KalmDownCSharp.ViewModels;
    using Ninject.Modules;

    internal class KalmDownModule : NinjectModule
    {
        public override void Load()
        {
            // Infrastructure
            Bind<IMediator>().To<Mediator>().InSingletonScope();

            // Managers
            Bind<ISettingManager>().To<SettingManager>().InSingletonScope();
            Bind<ITimerManager>().To<TimerManager>().InSingletonScope();

            // ViewModels
            Bind<ISettingWindowViewModel>().To<SettingWindowViewModel>().InSingletonScope();
            Bind<IMainWindowViewModel>().To<MainWindowViewModel>().InSingletonScope();
        }
    }
}
