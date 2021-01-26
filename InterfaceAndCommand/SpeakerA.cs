using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndCommand
{
    class SpeakerA : ISpeak
    {
        public void Speak()
        {
            Console.WriteLine("AAAAA");
        }
    }
}
