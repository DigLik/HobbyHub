using HobbyHub.Abstract;

namespace HobbyHub.Commands
{
    public class Router
    {
        private static readonly Dictionary<string, ICommand> commands = [];
        private static char commandPrefix = '/';
        public static void RegisterCommand(string command, ICommand commandInstance)
        {
            if (command[0] == commandPrefix) command = command[1..];
            commands.Add(commandPrefix + command, commandInstance);
        }
        public static bool TryGetCommand(string command, out ICommand? outCommand)
        {
            if (command[0] == commandPrefix) command = command[1..];
            return commands.TryGetValue(commandPrefix + command, out outCommand);
        }

        public static void SetCommandPrefix(char prefix)
        {
            commandPrefix = prefix;
        }
    }
}
