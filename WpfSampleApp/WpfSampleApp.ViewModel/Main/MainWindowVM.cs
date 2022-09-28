using System.Windows;
using System.Windows.Controls;
using WpfSampleApp.Interface.Main;
using WpfSampleApp.ViewModel.Common;
using WpfSampleApp.ViewModel.Main.Manu;

namespace WpfSampleApp.ViewModel.Main
{
    public class MainWindowVM : BaseVM, IMainWindowVM
    {
        public IMenu MenuCtrlVM { get => _menuCtrlVM; }
        public ISubView DropImageUserCtrlVM { get => _dropImageUserCtrlVM; }

        private IMenu _menuCtrlVM;
        private ISubView _dropImageUserCtrlVM;

        public MainWindowVM()
        {
            _menuCtrlVM = new MenuUserControlVM(this);
            _dropImageUserCtrlVM = new DropImageUserControlVM(this);
        }
    }
}
