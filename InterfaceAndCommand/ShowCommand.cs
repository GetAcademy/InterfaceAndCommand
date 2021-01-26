using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndCommand
{
    class ShowCommand:ICommand
    {
        private Stats _stats;

        public ShowCommand(Stats stats)
        {
            _stats = stats;
        }

        public void Run()
        {
            Console.WriteLine(_stats.GetStats());
        }

        public bool IsMatch(string commandName)
        {
            return commandName.ToLower() == "show";
        }
    }
}
