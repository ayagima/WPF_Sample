using System.Windows.Controls;
using System.Windows.Input;
using WpfSampleApp.Interface.Main;
using WpfSampleApp.ViewModel.Common;

namespace WpfSampleApp.ViewModel.Main.Manu
{
    public class MenuItemVM : BaseVM, IMenuItem
    {
        public IMenu ParentMenu { get => _parentMenu; }
        public string Title { get => _title; }
        public ICommand Command { get => _command; }
        public object? MenuItemCommandParam { get => _menuItemCommandParam; }
        public bool IsSelected { get; set; }

        private IMenu _parentMenu;
        private string _title;
        private ICommand _command;
        private object? _menuItemCommandParam;

        public MenuItemVM(IMenu parentMenu, IMenuItemCommand command)
        {
            _parentMenu = parentMenu;
            _title = command.Title;
            _command = command;
            _menuItemCommandParam = this;
        }
    }
}
