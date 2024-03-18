using IziHardGames.BotForTelegram;
using System;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace MyNamespace
{
    class Program
    {
        public static void Main(params string[] args)
        {
            string json = File.ReadAllText("config.json");
            ConfigForBotForTelegram[] configs = JsonSerializer.Deserialize<ConfigForBotForTelegram[]>(json);
            TelegramClient telegramClient = new TelegramClient(configs.First(x => x.Active));
            telegramClient.RunAsync();

            Console.WriteLine($"App exit");
            Console.ReadLine();
        }
    }
}