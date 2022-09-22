using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfSampleApp.Interface.Main;

namespace WpfSampleApp.Command.Main
{
    public class SelectionChangedCommand : ICommand
    {
        public static SelectionChangedCommand Instance = new SelectionChangedCommand();

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            var menu = parameter as IMenu;
            if (menu == null)
                return;

            var selectedMenu = menu.SelectedMenuItem;
            if (selectedMenu is null)
                return;

            selectedMenu.Command.Execute(parameter);
        }
    }
}
