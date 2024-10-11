using Discord.WebSocket;

namespace Bot.commands.types;

public class TestCommand : CommandBase, CustomCommand
{

    public TestCommand(String cmd, String usage) : base(cmd, usage)
    {
        
    }
    
    public async void Execute(SocketMessage message)
    {
        
        await message.Channel.SendMessageAsync(GetUsage());
        
    }
}