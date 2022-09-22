using WpfSampleApp.Interface.Main;
using WpfSampleApp.ViewModel.Common;

namespace WpfSampleApp.ViewModel.Main
{
    public class MenuItem : BaseVM
    {
        public string Name { get => _name; }

        private string _name = "サンプル";

        public static MenuItem Create()
        {
            var instance = new MenuItem();
            return instance;
        }

        public MenuItem()
        {
        }
    }
}
