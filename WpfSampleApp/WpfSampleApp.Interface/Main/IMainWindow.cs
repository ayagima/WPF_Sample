using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfSampleApp.Interface.Main
{
    public interface IMainWindowVM
    {
        IMenu MenuCtrlVM { get; }
        ISubView SubViewUserCtrlVM { get; }
        SubViewType SelectionViewType { get; set; }
    }

    public interface IMenu
    {
        IMainWindowVM MainWindowVM { get; }
        IMenuItem? SelectedMenuItem { get; }
        void MakeMenu(IMenuItemCommand command);
        void AllClear();
    }

    public interface ISubView
    {
        IMainWindowVM MainWindowVM { get; }
        Visibility Visibility { get; set; }
        SubViewType Type { get; }
    }

    public interface IMenuItem
    {
        IMenu ParentMenu { get; }
        string Title { get; }
        ICommand Command { get; }
        bool IsSelected { get; set; }

    }

    public interface IMenuItemCommand : ICommand
    {
        string Title { get; }
    }

    public enum SubViewType
    {
        None = 0,
        DropImage,
    }
}
