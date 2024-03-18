using System.Text.Json;

namespace IziHardGames.BotForTelegram.Organizing
{
    public class BotForOrganizing
    {
        //public Chat chat;
        public TelegramClient client;


        public BotForOrganizing(string configPath = "../")
        {

        }

        public Task RunAsync()
        {
            string json = File.ReadAllText("config.json");
            ConfigForBotForTelegram[] configs = JsonSerializer.Deserialize<ConfigForBotForTelegram[]>(json);
            TelegramClient telegramClient = new TelegramClient(configs.First(x => x.Active));
            var t1 = telegramClient.RunAsync();
            return t1;
        }
    }
}
