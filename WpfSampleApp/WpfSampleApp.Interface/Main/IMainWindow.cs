using System.ComponentModel;

namespace WpfSampleApp.Interface.Main
{
    public interface IMainWindowVM
    {
    }

    public interface IMenu
    {
        void Add(INotifyPropertyChanged vm);
        void AllClear();
    }
}
