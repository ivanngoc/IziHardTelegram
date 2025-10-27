using System.Threading.Tasks;
using IziHardGames.ForTelegram.Accounting;
using Microsoft.AspNetCore.Mvc;

namespace PlaygroundTGWebAPI.Controllers
{
    [Route("[controller]")]
    public class TgAccountController : ControllerBase
    {
        private IziTgAccount client;

        public TgAccountController(IziTgAccount client)
        {
            this.client = client;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            throw new System.NotImplementedException();
        }
    }
}
