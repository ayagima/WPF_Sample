using System.Windows;
using WpfSampleApp.Interface.Main;
using WpfSampleApp.ViewModel.Common;

namespace WpfSampleApp.ViewModel
{
    public class DropImageUserControlVM : BaseVM, ISubView
    {
        public Visibility Visibility
        {
            get => _visibility;
            set
            {
                if (_visibility == value)
                    return;
                _visibility = value;
                OnPropertyChanged(nameof(Visibility));
            }
        }
        public IMainWindowVM MainWindowVM { get => _mainWindowVM; }

        private Visibility _visibility;
        private IMainWindowVM _mainWindowVM;

        public DropImageUserControlVM(IMainWindowVM mainWindowVM)
        {
            _mainWindowVM = mainWindowVM;
            _visibility = Visibility.Collapsed;
        }
    }
}
