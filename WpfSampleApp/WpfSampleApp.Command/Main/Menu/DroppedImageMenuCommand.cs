using WpfSampleApp.Interface.Main;

namespace WpfSampleApp.Command.Main.Menu
{
    public class DroppedImageMenuCommand : IMenuItemCommand
    {
        public static DroppedImageMenuCommand Instance = new DroppedImageMenuCommand();
        public string Title { get => Resource.CMD_TITLE_DroppedImageMenu; }

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

            var menuItem = menu.SelectedMenuItem;
            if (menuItem is null)
                return;

            menuItem.Show();
        }
    }
}
