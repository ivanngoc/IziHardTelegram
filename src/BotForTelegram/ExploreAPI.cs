using System;
using System.Linq;
using System.Reflection;
using Telegram.Td;
using Telegram.Td.Api;

namespace IziHardGames.ForTelegram
{
    public class ExploreAPI
    {
        public static void PrintInterfaceImplements(Type type)
        {
            if (!type.IsInterface) throw new ArgumentOutOfRangeException($"Not interface: " + type.AssemblyQualifiedName);
            var ar = typeof(Function).Assembly.GetTypes().ToArray();
            var implements = ar.Where(x => x.GetInterfaces().Any(x => x == type)).ToArray();

            foreach (var imp in implements)
            {
                Console.WriteLine(imp.AssemblyQualifiedName);
            }
        }
        public static void PrintAllCommands()
        {
            var asm = typeof(Client).Assembly;
            var ar = asm.GetTypes().ToArray();
            var functions = ar.Where(x => x.GetInterfaces().Any(x => x == typeof(Function))).ToArray();
            var functions2 = ar.Where(x => x.GetInterfaces().Any(x => x is GetMe)).ToArray();
            foreach (var func in functions)
            {
                Console.WriteLine(func.AssemblyQualifiedName);
            }
        }
    }
}