using System.Windows.Input;
using WpfSampleApp.Interface.Main;

namespace WpfSampleApp.Command.Main
{
    public class LoadingMenuCommand : ICommand
    {
        public static LoadingMenuCommand Instance = new LoadingMenuCommand();

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
        }
    }
}
