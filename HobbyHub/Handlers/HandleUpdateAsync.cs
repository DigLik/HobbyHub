using HobbyHub.Abstract;
using HobbyHub.Commands;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace HobbyHub.Handlers
{
    public partial class Handlers
    {
        public static async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            if (update.Type == UpdateType.Message)
            {
                if (Router.TryGetCommand(update.Message.Text, out ICommand command))
                {
                    await command.ExecuteAsync(botClient, update, cancellationToken);
                }
                else
                {
                    await new Commands.CommandsBase.NotFoundCommand().ExecuteAsync(botClient, update, cancellationToken);
                }
            }
        }
    }
}
