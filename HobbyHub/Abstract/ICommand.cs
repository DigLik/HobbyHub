using Telegram.Bot.Types;
using Telegram.Bot;

namespace HobbyHub.Abstract
{
    public interface ICommand
    {
        Task ExecuteAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken);
    }
}
