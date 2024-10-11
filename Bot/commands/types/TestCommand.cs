using Discord;
using Discord.WebSocket;

namespace Bot.commands.types;

public class TestCommand : CommandBase, CustomCommand
{

    public TestCommand(String cmd, String usage, Dictionary<String, ApplicationCommandOptionType> options) : base(cmd, usage, options)
    {
        
    }
    
    public async Task Execute(SocketSlashCommand command)
    {
        await command.RespondAsync(GetUsage());
    }
}