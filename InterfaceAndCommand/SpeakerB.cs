using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndCommand
{
    class SpeakerB : ISpeak
    {
        public void Speak()
        {
            Console.WriteLine("BBBBB");
        }
    }
}
