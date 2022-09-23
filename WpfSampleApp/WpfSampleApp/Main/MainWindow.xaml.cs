using System.Windows;
using WpfSampleApp.ViewModel.Main;

namespace WpfSampleApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowVM _mainWindowVM;

        public MainWindow()
        {
            InitializeComponent();
            _mainWindowVM = new MainWindowVM();
            DataContext = _mainWindowVM;
        }
    }
}
