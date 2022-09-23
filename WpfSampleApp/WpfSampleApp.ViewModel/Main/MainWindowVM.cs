using System.Windows.Controls;
using WpfSampleApp.Interface.Main;
using WpfSampleApp.ViewModel.Common;
using WpfSampleApp.ViewModel.Main.Manu;

namespace WpfSampleApp.ViewModel.Main
{
    public class MainWindowVM : BaseVM, IMainWindowVM
    {
        public IMenu MenuCtrlVM { get => _menuCtrlVM; }
        public UserControl? SubView { get => _menuCtrlVM.SelectedMenuItem?.ViewCtrl; }

        private IMenu _menuCtrlVM;

        public MainWindowVM()
        {
            _menuCtrlVM = new MenuUserControlVM(this);
        }

        public void UpdateSubView()
        {
            OnPropertyChanged(nameof(this.SubView));
        }
    }
}
