using IziHardGames.BotForTelegram;
using IziHardGames.ForTelegram.Accounting;
using System;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Telegram.Td;
using Telegram.Td.Api;

namespace IziHardGames.ForTelegram
{
    class Program
    {
        public static async Task Main(params string[] args)
        {
            Console.WriteLine(typeof(Client).Assembly.FullName);

            var client = await IziTgAccount.Default();

            //await foreach (var item in client.Chats())
            //{
            //    Console.WriteLine(item);
            //}
            //ExploreAPI.PrintInterfaceImplements(typeof(ChatList));
            //Console.WriteLine("=========================================");
            //ExploreAPI.PrintInterfaceImplements(typeof(ClientResultHandler));
            //Console.WriteLine("=========================================");
            //Console.WriteLine();
            //ExploreAPI.PrintAllCommands();

            //Console.WriteLine($"App exit");
            //Console.ReadLine();
            Console.WriteLine("Completed");
        }
    }
}