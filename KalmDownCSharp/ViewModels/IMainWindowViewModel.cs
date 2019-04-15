namespace KalmDownCSharp.ViewModels
{
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Media.Animation;

    public interface IMainWindowViewModel
    {
        Storyboard CreateCatStoryboard(Grid catGrid, PropertyPath propertyPath);
    }
}
