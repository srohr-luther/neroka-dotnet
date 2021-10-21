using System.Threading;
using System.Threading.Tasks;
using Discord.WebSocket;

namespace Com.Github.SRohrLuther.Neroka
{
    public class Program
    {
        private readonly DiscordSocketClient _client;

        public Program()
        {
            _client = new DiscordSocketClient();
            _client.MessageReceived += MessageReceivedAsync;
        }

        private async Task MessageReceivedAsync(SocketMessage message)
        {
            if (message.Author.Id == _client.CurrentUser.Id)
            {
                return;
            }

            if (message.Content == "!ping")
            {
                await message.Channel.SendMessageAsync("pong!");
            }
        }

        public async Task Run()
        {
            var botToken = System.Environment.GetEnvironmentVariable("BOT_TOKEN");

            await _client.LoginAsync(Discord.TokenType.Bot, botToken);
            await _client.StartAsync();

            await Task.Delay(Timeout.Infinite);
        }

        public static async Task Main(string[] args)
        {
            await new Program().Run();
        }
    }
}
