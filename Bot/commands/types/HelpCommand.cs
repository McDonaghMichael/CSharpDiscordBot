﻿using Discord;
using Discord.WebSocket;

namespace Bot.commands.types;

public class HelpCommand : CommandBase, CustomCommand
{

    public HelpCommand(String cmd, String usage, Dictionary<String, ApplicationCommandOptionType> options) : base(cmd, usage, options)
    {
    }
    
    public async Task Execute(SocketSlashCommand command)
    {

        var embed = new EmbedBuilder
        {
            Title = "HELP CENTRE",
            Description = "I am a description set by initializer."
        };
        
        
        await command.RespondAsync(embed: embed.Build());
    }
}