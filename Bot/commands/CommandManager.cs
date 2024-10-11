using Bot.commands;
using Bot.commands.types;
using static Bot.commands.CustomCommand;

namespace Bot
{
    public class CommandManager
    {
        static CustomCommand[] commands = new CustomCommand[10];  

        public CommandManager()
        {
            commands[0] = new HelpCommand("!help", "!help <commands>");
            commands[1] = new TestCommand("!test", "!test");
        }

        public static CustomCommand[] GetCommands()
        {
            return commands;
        }
    }
}
