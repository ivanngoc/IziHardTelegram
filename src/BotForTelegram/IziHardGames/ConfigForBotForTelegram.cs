using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace IziHardGames.BotForTelegram
{
    public class ConfigForBotForTelegram
    {
        [JsonPropertyName("active")]
        public bool Active { get; set; }

        [JsonPropertyName("number")]
        public string Number { get; set; }

        [JsonPropertyName("api_id")]
        public int ApiId { get; set; }

        [JsonPropertyName("api_hash")]
        public string ApiHash { get; set; }

        [JsonPropertyName("system_language_code")]
        public string SystemLanguageCode { get; set; }
        /// TODO: avoid open form
        [JsonPropertyName("pwd")]
        public string Password { get; set; }
    }
}
