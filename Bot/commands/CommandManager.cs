using Bot.commands;
using Bot.commands.types;
using Discord;
using Discord.Net;
using Discord.WebSocket;
using Newtonsoft.Json;
using static Bot.commands.CustomCommand;

namespace Bot
{
    public class CommandManager
    {
        static CustomCommand[] commands = new CustomCommand[10];  
        
        private async Task SlashCommandHandler(SocketSlashCommand command)
        {
            var cmd = commands.FirstOrDefault(c => c.GetName() == command.Data.Name);
            if (cmd != null)
            {
  
                 cmd.Execute(command);
            }
            else
            {
                await command.RespondAsync("Unknown command.");
            }
        }


        public CommandManager(DiscordSocketClient client)
        
        {
            
            client.SlashCommandExecuted += SlashCommandHandler;
            
            var helpOptions = new Dictionary<String, ApplicationCommandOptionType>();
            helpOptions.Add("user", ApplicationCommandOptionType.User);
            commands[0] = new HelpCommand("help", "!help <commands>", helpOptions);
            
            var insultOptions = new Dictionary<String, ApplicationCommandOptionType>();
            insultOptions.Add("user", ApplicationCommandOptionType.User);
            commands[1] = new InsultCommand("insult", "!insult <user>", insultOptions);
            
            //commands[1] = new TestCommand("test", "!test", options);

            for (int i = 0; i < commands.Length; i++)
            {
  
                var guildCommand = new SlashCommandBuilder();
                guildCommand.WithName(commands[i].GetName());
                guildCommand.WithDescription(commands[i].GetUsage());
                foreach (var optionType in commands[i].GetOptions())
                {
                    guildCommand.AddOption(optionType.Key, optionType.Value, "Description of the option");
                }
            
                try
                { 
                    var guild = client.GetGuild(1174461950382579719);
                    guild.CreateApplicationCommandAsync(guildCommand.Build());
                
                }
                catch(ApplicationCommandException exception)
                { var json = JsonConvert.SerializeObject(exception.Errors, Formatting.Indented);
                    Console.WriteLine(json);
                }
            }
            
            
        }

        public static CustomCommand[] GetCommands()
        {
            return commands;
        }
    }
}
