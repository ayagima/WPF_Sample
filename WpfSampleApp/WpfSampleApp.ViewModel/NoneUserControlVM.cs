using System.Windows;
using WpfSampleApp.Interface.Main;
using WpfSampleApp.ViewModel.Common;

namespace WpfSampleApp.ViewModel
{
    public class NoneUserControlVM : BaseVM, ISubView
    {
        private IMainWindowVM _mainWindowVM;
        private Visibility _visibility;

        public NoneUserControlVM(IMainWindowVM mainWindowVM)
        {
            _mainWindowVM = mainWindowVM;
            _visibility = Visibility.Visible;
        }


        public IMainWindowVM MainWindowVM { get => _mainWindowVM; }
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
    }
}
