using HobbyHub.Abstract;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace HobbyHub.Commands.CommandsBase
{
    public class StartCommand : ICommand
    {
        public async Task ExecuteAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            await botClient.SendTextMessageAsync(update.Message.Chat.Id, "Привет чертилы.", cancellationToken: cancellationToken);
        }
    }
}
