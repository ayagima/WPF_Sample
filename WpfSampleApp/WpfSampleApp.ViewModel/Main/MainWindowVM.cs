using System.Windows;
using System.Windows.Controls;
using WpfSampleApp.Interface.Main;
using WpfSampleApp.ViewModel.Common;
using WpfSampleApp.ViewModel.Main.Manu;

namespace WpfSampleApp.ViewModel.Main
{
    public class MainWindowVM : BaseVM, IMainWindowVM
    {
        private IMenu _menuCtrlVM;
        private ISubView _subViewUserCtrlVM;
        private NoneUserControlVM _noneUserControlVM;
        private DropImageUserControlVM _dropImageUserCtrlVM;

        public MainWindowVM()
        {
            _menuCtrlVM = new MenuUserControlVM(this);
            _noneUserControlVM = new NoneUserControlVM(this);
            _dropImageUserCtrlVM = new DropImageUserControlVM(this);
            _subViewUserCtrlVM = _noneUserControlVM;
        }
        public IMenu MenuCtrlVM { get => _menuCtrlVM; }
        public ISubView SubViewUserCtrlVM { get => _subViewUserCtrlVM; }
        public SubViewType SelectionViewType { get => _subViewUserCtrlVM.Type; }
    }
}
