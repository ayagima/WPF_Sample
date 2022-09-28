﻿using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfSampleApp.Interface.Main
{
    public interface IMainWindowVM
    {
        IMenu MenuCtrlVM { get; }
        ISubView DropImageUserCtrlVM { get; }
    }

    public interface IMenu
    {
        IMainWindowVM MainWindowVM { get; }
        IMenuItem? SelectedMenuItem { get; }
        void MakeMenu(IMenuItemCommand command);
        void AllClear();
    }

    public interface ISubView
    {
        IMainWindowVM MainWindowVM { get; }
        Visibility SubViewVisibility { get; set; }
    }

    public interface IMenuItem
    {
        IMenu ParentMenu { get; }
        string Title { get; }
        ICommand Command { get; }
        bool IsSelected { get; set; }

    }

    public interface IMenuItemCommand : ICommand
    {
        string Title { get; }
    }
}
