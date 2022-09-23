using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfSampleApp.Interface.Main
{
    public interface IMainWindowVM
    {
        void UpdateSubView();
    }

    public interface IMenu
    {
        IMainWindowVM MainWindowVM { get; }
        IMenuItem? SelectedMenuItem { get; }
        void MakeMenu(IMenuItemCommand command);
        void AllClear();
    }

    public interface IMenuItem
    {
        string Title { get; }
        ICommand Command { get; }
        UserControl ViewCtrl { get; }
    }

    public interface IMenuItemCommand : ICommand
    {
        string Title { get; }
        UserControl ViewCtrl { get; }
    }
}
