using System.Windows.Controls;
using System.Windows.Input;
using WpfSampleApp.Interface.Main;
using WpfSampleApp.ViewModel.Common;

namespace WpfSampleApp.ViewModel.Main.Manu
{
    public class MenuItem : BaseVM, IMenuItem
    {
        public string Title { get => _title; }
        public ICommand Command { get => _command; }
        public object? MenuItemCommandParam { get => _menuItemCommandParam; }
        public bool IsSelected { get; set; }
        public UserControl ViewCtrl { get => _viewCtrl; }

        private string _title;
        private ICommand _command;
        private object? _menuItemCommandParam;
        private UserControl _viewCtrl;

        public MenuItem(IMenuItemCommand command)
        {
            _title = command.Title;
            _command = command;
            _menuItemCommandParam = this;
            _viewCtrl = command.ViewCtrl;
        }
    }
}
