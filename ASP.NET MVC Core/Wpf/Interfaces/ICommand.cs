
using System;

namespace Wpf.Interfaces;

internal interface ICommand
{
    event EventHandler CanExecuteChanged;
    void Execute(object parameter);
    bool CanExecute(object parameter);
}
