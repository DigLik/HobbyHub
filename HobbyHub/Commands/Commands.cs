using HobbyHub.Commands.CommandsBase;

namespace HobbyHub.Commands
{
    public class Commands
    {
        public static void RegisterCommands()
        {
            Router.RegisterCommand("start", new StartCommand());
        }
    }
}
