using Telegram.Bot;
using static HobbyHub.Handlers.Handlers;

namespace HobbyHub
{
    public class Program
    {
        private static readonly string? _token = Environment.GetEnvironmentVariable("Token");
        private static TelegramBotClient? bot;

        static async Task Main(string[] args)
        {
            if (_token == null) throw new InvalidOperationException("Token is null.");

            bot = new TelegramBotClient(_token) ?? throw new InvalidOperationException("Bot is null.");

            Commands.Commands.RegisterCommands();

            var me = await bot.GetMeAsync();
            Console.WriteLine($"Бот ({me.FirstName}) запущен.");

            bot.StartReceiving(
                HandleUpdateAsync,
                HandleErrorAsync
            );

            await Task.Delay(-1);
        }
    }
}
