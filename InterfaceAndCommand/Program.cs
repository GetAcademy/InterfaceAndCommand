using System;
using System.Linq;
using System.Reflection;

namespace InterfaceAndCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            ReflectionThing();
            return;
            var stats = new Stats();
            var commands = new ICommand[]
            {
                new AddNumberCommand(stats),
                new ResetCommand(stats),
                new ShowCommand(stats),
            };
            //ISpeak speaker = new SpeakerB();
            //speaker.Speak();
            Console.WriteLine("Velkommen");
            do
            {
                Console.Write("Kommando: ");
                var commandStr = Console.ReadLine();
                var command = commands.FirstOrDefault(c => c.IsMatch(commandStr));
                command?.Run();
            } while (true);
        }

        static void ReflectionThing()
        {
            var commandType = typeof(ICommand);
            var implementingTypes = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => commandType.IsAssignableFrom(t))
                .Where(t =>  t != commandType);
            //.Where(IsSubclass);
            foreach (var type in implementingTypes)
            {
                Console.WriteLine(type.Name);
            }
        }

        //static bool IsSubclass(Type type)
        //{
        //    return type.IsSubclassOf(typeof(ICommand));
        //}
    }
}
