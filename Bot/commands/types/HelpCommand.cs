using Discord.WebSocket;

namespace Bot.commands.types;

public class HelpCommand : CommandBase, CustomCommand
{

    public HelpCommand(String cmd, String usage) : base(cmd, usage)
    {
        
    }
    
    public async void Execute(SocketMessage message)
    {
        
        await message.Channel.SendMessageAsync("Usage: !help <message>");
        
    }
}