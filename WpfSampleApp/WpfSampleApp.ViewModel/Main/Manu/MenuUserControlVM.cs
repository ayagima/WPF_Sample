using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using WpfSampleApp.Command.Main;
using WpfSampleApp.Interface.Main;
using WpfSampleApp.ViewModel.Common;

namespace WpfSampleApp.ViewModel.Main.Manu
{
    public class MenuUserControlVM : BaseVM, IMenu
    {
        public IEnumerable<MenuItem> Menu { get => _menu; }
        public IMainWindowVM MainWindowVM { get => _mainWindowVM; }
        public ICommand LoadingMenuCmd { get => _menuLoadCmd; }
        public object? LoadingMenuCmdParam { get => _menuLoadCmdParam; }
        public ICommand SelectionChangedCmd { get => _selectionChangedCmd; }
        public object? SelectionChangedCmdParam { get => _selectionChangedCmdParam; }
        public IMenuItem? SelectedMenuItem { get => Menu.Where(q => q.IsSelected == true).FirstOrDefault(); }

        private ObservableCollection<MenuItem> _menu = new ObservableCollection<MenuItem>();
        private IMainWindowVM _mainWindowVM;
        private LoadingMenuCommand _menuLoadCmd;
        private object _menuLoadCmdParam;
        private SelectionChangedCommand _selectionChangedCmd;
        private object _selectionChangedCmdParam;

        public MenuUserControlVM(IMainWindowVM mainWindowVM)
        {
            _mainWindowVM = mainWindowVM;
            _menuLoadCmd = LoadingMenuCommand.Instance;
            _menuLoadCmdParam = this;
            _selectionChangedCmd = SelectionChangedCommand.Instance;
            _selectionChangedCmdParam = this;
        }
        public void MakeMenu(IMenuItemCommand command)
        {
            if (command is null)
                throw new ArgumentNullException(nameof(command));
            _menu.Add(new MenuItem(command));
        }
        public void AllClear()
        {
            _menu.Clear();
        }
    }
}
