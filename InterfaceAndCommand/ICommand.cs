using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndCommand
{
    interface ICommand
    {
        void Run();
        bool IsMatch(string commandName);
    }
}
