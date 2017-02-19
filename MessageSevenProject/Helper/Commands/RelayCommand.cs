using System;
using System.Windows.Input;

namespace MessageSevenProject.Helper.Commands
{
    public class RelayCommand : ICommand
    {

        private readonly Action<object> _execute;
        private readonly Predicate<object> _canexecute;

        public RelayCommand(Action<object> execute) :this(execute,null)
        {

        }

        public RelayCommand(Action<object> execute,Predicate<object> canexecute)
        {

            if(execute==null)
            {
                throw new ArgumentNullException(nameof(execute));
            }

            if(canexecute==null)
            {
                throw new ArgumentNullException(nameof(canexecute));
            }

            _execute = execute;
            _canexecute = canexecute;
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }

            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public bool CanExecute(object parameter)
        {
            return _canexecute != null && _canexecute(parameter);
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }
    }
}
