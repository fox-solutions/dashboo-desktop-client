using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace dashboo.Base.ViewModelSupport
{
    public class RelayCommand : ICommand
    {
        private Action<object> execute;
        private Predicate<object> canExecute;

        public event EventHandler CanExecuteChanged = delegate { };

        public void OnCanExecuteChanged()
        {
            CanExecuteChanged(this, EventArgs.Empty);
        }


        public bool CanExecute(object parameter)
        {
            if (canExecute == null)
            {
                return true;
            }
            else
            {
                return canExecute.Invoke(parameter);
            }
        }

        public void Execute(object parameter)
        {
            execute.Invoke(parameter);
        }
    }
}
