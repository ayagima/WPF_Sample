﻿using System.ComponentModel;
using System.Windows.Input;

namespace WpfSampleApp.Interface.Main
{
    public interface IMainWindowVM
    {
    }

    public interface IMenu
    {
        IMenuItem? SelectedMenuItem { get; }
        void MakeMenu(IMenuItemCommand command);
        void AllClear();
    }

    public interface IMenuItem
    {
        string Title { get; }
        ICommand Command { get; }
        void Show();
    }

    public interface IMenuItemCommand : ICommand
    {
        string Title { get; }
    }
}
