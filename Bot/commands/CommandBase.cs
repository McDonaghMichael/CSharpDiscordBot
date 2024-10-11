using Discord;

namespace Bot.commands;

public class CommandBase
{
    protected string CommandName;
    protected string CommandUsage;
    protected Dictionary<String, ApplicationCommandOptionType> CommandOptions;

    public CommandBase(string commandName, string usage, Dictionary<String, ApplicationCommandOptionType> options)
    {
        CommandName = commandName;
        CommandUsage = usage;
        CommandOptions = options;
    }

    public String GetName()
    {
        return CommandName;
    }

    public String GetUsage()
    {
        return CommandUsage;
    }

    public Dictionary<String, ApplicationCommandOptionType> GetOptions()
    {
        return CommandOptions;
    }
}