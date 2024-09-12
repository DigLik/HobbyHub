using HobbyHub.Abstract;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace HobbyHub.Commands.CommandsBase
{
    public class NotFoundCommand : ICommand
    {
        public async Task ExecuteAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            await botClient.SendTextMessageAsync(update.Message.Chat.Id, "Команда не найдена.", cancellationToken: cancellationToken);
        }
    }
}
