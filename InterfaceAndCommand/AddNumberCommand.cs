using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndCommand
{
    class AddNumberCommand : ICommand
    {
        private Stats _stats;

        public AddNumberCommand(Stats stats)
        {
            _stats = stats;
        }

        public void Run()
        {
            Console.Write("Skriv tall: ");
            var numberStr = Console.ReadLine();
            var number = Convert.ToInt32(numberStr);
            _stats.AddNumber(number);
        }

        public bool IsMatch(string commandName)
        {
            return commandName.ToLower() == "add";
        }
    }
}
