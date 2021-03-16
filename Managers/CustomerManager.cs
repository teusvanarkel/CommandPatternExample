using CommandPatternExample.Interfaces;

namespace CommandPatternExample.Managers
{
    public class CustomerManager 
    {
        private ICommand _command;
        public void ExecuteCommand()
        {
            _command.Execute();
        }

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

    }
}