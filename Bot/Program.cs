using Discord;
using Discord.WebSocket;
using DotNetEnv;

namespace Bot;

class Program
{
    private static DiscordSocketClient _client;

    private static CommandManager commandManager;

    public static async Task Main(string[] args)
    {
        
        Env.Load();
       
        var config = new DiscordSocketConfig
        {
            GatewayIntents = GatewayIntents.AllUnprivileged | GatewayIntents.MessageContent
        };
        
        
        _client = new DiscordSocketClient(config);
        
        _client.Log += LogAsync;
        _client.Ready += ReadyAsync;
        _client.MessageReceived += MessageReceivedAsync;
        _client.InteractionCreated += InteractionCreatedAsync;
        
        await _client.SetCustomStatusAsync("Let's get it on");

        Console.WriteLine(Env.GetString("TOKEN"));
        await _client.LoginAsync(TokenType.Bot, Environment.GetEnvironmentVariable("TOKEN"));
        

        await _client.StartAsync();
        
        await Task.Delay(Timeout.Infinite);
    }

    private static Task LogAsync(LogMessage log)
    {
        Console.WriteLine(log.ToString());
        return Task.CompletedTask;
    }
    
    private static Task ReadyAsync()
    {
        Console.WriteLine($"{_client.CurrentUser} is connected!");
        
        commandManager = new CommandManager(_client);

        
        return Task.CompletedTask;
    }
    
    private static async Task MessageReceivedAsync(SocketMessage message)
    {
        if (message.Author.Id == _client.CurrentUser.Id)
            return;
    }
    
    private static async Task InteractionCreatedAsync(SocketInteraction interaction)
    {
        
        if (interaction is SocketMessageComponent component)
        {
          
            if (component.Data.CustomId == "unique-id")
                await interaction.RespondAsync("Thank you for clicking my button!");

            else
                Console.WriteLine("An ID has been received that has no handler!");
        }
    }
}