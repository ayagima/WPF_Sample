using System.Windows;
using WpfSampleApp.Interface.Main;
using WpfSampleApp.ViewModel.Common;
using WpfSampleApp.ViewModel.Main;

namespace WpfSampleApp.ViewModel
{
    public class DropImageUserControlVM : BaseVM, ISubView
    {
        public Visibility SubViewVisibility
        {
            get => _subViewVisibility;
            set
            {
                if (_subViewVisibility == value)
                    return;
                _subViewVisibility = value;
                OnPropertyChanged(nameof(SubViewVisibility));
            }
        }
        public IMainWindowVM MainWindowVM { get => _mainWindowVM; }

        private Visibility _subViewVisibility;
        private IMainWindowVM _mainWindowVM;

        public DropImageUserControlVM(IMainWindowVM mainWindowVM)
        {
            _mainWindowVM = mainWindowVM;
            _subViewVisibility = Visibility.Collapsed;
        }
    }
}
