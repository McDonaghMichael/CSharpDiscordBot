namespace Bot.commands;

public class CommandBase
{
    protected string CommandName;
    protected string CommandUsage;

    public CommandBase(string commandName, string usage)
    {
        CommandName = commandName;
        CommandUsage = usage;
    }

    public String GetName()
    {
        return CommandName;
    }

    public String GetUsage()
    {
        return CommandUsage;
    }
}