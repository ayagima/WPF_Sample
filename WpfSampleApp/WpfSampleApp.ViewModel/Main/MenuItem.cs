using System.Windows.Input;
using WpfSampleApp.Interface.Main;
using WpfSampleApp.ViewModel.Common;

namespace WpfSampleApp.ViewModel.Main
{
    public class MenuItem : BaseVM, IMenuItem
    {
        public string Title { get => _title; }
        public ICommand Command { get => _command; }
        public object? MenuItemCommandParam { get => _menuItemCommandParam; }
        public bool IsSelected { get; set; }

        private string _title;
        private ICommand _command;
        private object? _menuItemCommandParam;

        public MenuItem(IMenuItemCommand command)
        {
            _title = command.Title;
            _command = command;
            _menuItemCommandParam = this;
        }
    }
}
