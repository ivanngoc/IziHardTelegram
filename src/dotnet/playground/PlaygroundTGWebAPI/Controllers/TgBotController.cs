using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Telegram.Bots;
using Telegram.Bots.Requests;
using Telegram.Bots.Types;

namespace PlaygroundTGWebAPI.Controllers
{
    [Route("[controller]")]
    public class TgBotController : ControllerBase
    {
        private readonly IBotClient bot;

        public TgBotController(ILogger<TgBotController> logger, IBotClient bot)
        {
            this.bot = bot;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            GetMe request = new();

            Response<MyBot> response = await bot.HandleAsync(request);

            if (response.Ok)
            {
                MyBot myBot = response.Result;

                Console.WriteLine(myBot.Id);
                Console.WriteLine(myBot.FirstName);
                Console.WriteLine(myBot.Username);
                return Ok($"{myBot.Id}; {myBot.FirstName}; {myBot.Username}");
            }
            else
            {
                Failure failure = response.Failure;
                Console.WriteLine(failure.Description);
                return Ok($"Failure: {failure}");
            }
            //bot.HandleAsync
        }
    }
}
