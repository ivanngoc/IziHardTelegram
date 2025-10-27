using System.Text.Json;
using IziHardGames.ForTelegram.Accounting;

namespace IziHardGames.BotForTelegram.Organizing
{
    public class BotForOrganizing
    {
        //public Chat chat;
        public IziTgAccount? client;


        public BotForOrganizing(string configPath = "../")
        {

        }

        public Task RunAsync()
        {
            string json = File.ReadAllText("config.json");
            ConfigForBotForTelegram[] configs = JsonSerializer.Deserialize<ConfigForBotForTelegram[]>(json)!;
            IziTgAccount telegramClient = new IziTgAccount(configs.First(x => x.Active));
            var t1 = telegramClient.RunAsync();
            return t1;
        }
    }
}
