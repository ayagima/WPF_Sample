using WpfSampleApp.Interface.Main;
using WpfSampleApp.ViewModel.Common;
using WpfSampleApp.ViewModel.Main.Manu;

namespace WpfSampleApp.ViewModel.Main
{
    public class MainWindowVM : BaseVM, IMainWindowVM
    {
        public IMenu MenuCtrlVM { get => _menuCtrlVM; }

        private IMenu _menuCtrlVM;

        public MainWindowVM()
        {
            _menuCtrlVM = new MenuUserControlVM(this);
        }
    }
}
