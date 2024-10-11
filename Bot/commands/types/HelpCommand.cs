using Discord.WebSocket;

namespace Bot.commands.types;

public class HelpCommand : CommandBase, CustomCommand
{

    public HelpCommand(String cmd, String usage) : base(cmd, usage)
    {
        
    }
    
    public async Task Execute(SocketSlashCommand command)
    {
        // Respond to the slash command
        await command.RespondAsync(GetUsage());
    }
}