using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndCommand
{
    class ResetCommand:ICommand
    {
        private Stats _stats;

        public ResetCommand(Stats stats)
        {
            _stats = stats;
        }
        public void Run()
        {
            _stats.Reset();
        }

        public bool IsMatch(string commandName)
        {
            return commandName.ToLower() == "reset";
        }
    }
}
