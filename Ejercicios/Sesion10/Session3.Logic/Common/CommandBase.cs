using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Sesion3.Common
{
    public class CommandBase : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private Action action;
        private Func<bool> condition;

        public CommandBase(Action action, Func<bool> condition)
        {
            this.action = action;
            this.condition = condition;
        }

        public bool CanExecute(object parameter)
        {
            if (condition != null)
                return condition();

            return true;
        }

        public void Execute(object parameter)
        {
            action();
        }
    }
}
