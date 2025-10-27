using IziHardGames.BotForTelegram;
using System.Text.Json;

namespace IziHardGames.BotForTelegram.Organizing
{
    class Program
    {
        public static async Task Main(params string[] args)
        {
            var t1 = new BotForOrganizing().RunAsync();

            await Task.WhenAll(t1).ConfigureAwait(false);

            Console.WriteLine($"App exit");
            Console.ReadLine();
        }
    }
}