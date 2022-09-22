using System.Reflection.Metadata;
using System.Windows.Input;
using WpfSampleApp.Interface.Main;

namespace WpfSampleApp.Command.Menu
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
            Console.WriteLine("テストメッセージ");
        }
    }
}
