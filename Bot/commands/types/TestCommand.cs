using Discord.WebSocket;

namespace Bot.commands.types;

public class TestCommand : CommandBase, CustomCommand
{

    public TestCommand(String cmd, String usage) : base(cmd, usage)
    {
        
    }
    
    public async Task Execute(SocketSlashCommand command)
    {
        // Respond to the slash command
        await command.RespondAsync(GetUsage());
    }
}