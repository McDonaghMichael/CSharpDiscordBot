using Discord.WebSocket;

namespace Bot.commands
{
    public interface CustomCommand
    {
        
        Task Execute(SocketSlashCommand command); 
        String GetName();

        String GetUsage();
    }
}