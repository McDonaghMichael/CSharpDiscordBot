using Discord.WebSocket;

namespace Bot.commands
{
    public interface CustomCommand
    {
        void Execute(SocketMessage message);
        String GetName();
    }
}