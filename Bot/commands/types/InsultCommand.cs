using Discord;
using Discord.WebSocket;

namespace Bot.commands.types;

public class InsultCommand : CommandBase, CustomCommand
{

    public InsultCommand(String cmd, String usage, Dictionary<String, ApplicationCommandOptionType> options) : base(cmd, usage, options)
    {
    }
    
    public async Task Execute(SocketSlashCommand command)
    {
        var user = (SocketGuildUser)command.Data.Options.First().Value;
        
        await command.RespondAsync(user.Mention + " your a fat fuck");
    }
}