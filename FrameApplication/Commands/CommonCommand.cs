using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FrameApplication.Commands
{
    /// <summary>
    /// Reusable command using relaycommand 
    /// </summary>
    public class CommonCommand : ICommand
    {
        Func<object, bool> canExecute;
        Action<object> execute;

        public CommonCommand(Func<object, bool> canExecute, Action<object> execute)
        {
            this.canExecute = canExecute;
            this.execute = execute;
        }

        /// call System.Windows.Input.CommandManager.InvalidateRequerySuggested() to re evalute CanExecute().
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return canExecute.Invoke(parameter);
        }

        public void Execute(object parameter)
        {
            execute.Invoke(parameter);
        }
    }
}