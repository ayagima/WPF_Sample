﻿using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using WpfSampleApp.Command;
using WpfSampleApp.Interface.Main;
using WpfSampleApp.ViewModel.Common;

namespace WpfSampleApp.ViewModel.Main
{
    public class MenuUserControlVM : BaseVM, IMenu
    {
        public IEnumerable<MenuItem> Menu { get => _menu; }
        public IMainWindowVM MainWindowVM { get => _mainWindowVM; }
        public ICommand MenuLoadCommand { get => _menuLoadCommand; }

        private ObservableCollection<MenuItem> _menu = new ObservableCollection<MenuItem>();
        private IMainWindowVM _mainWindowVM;
        private LoadingMenuCommand _menuLoadCommand;

        public MenuUserControlVM(IMainWindowVM mainWindowVM)
        {
            _mainWindowVM = mainWindowVM;
            _menuLoadCommand = LoadingMenuCommand.Instance;
        }

        public void Add(INotifyPropertyChanged vm)
        {
            var item = vm as MenuItem;
            if (item == null)
                return;
            _menu.Add(item);
        }

        public void AllClear()
        {
            _menu.Clear();
        }
    }
}