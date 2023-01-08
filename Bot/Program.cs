using System;
using Discord;
using Discord.WebSocket;

public class Program {
    private DiscordSocketClient _client;
    
    public static Task Main(String[] args) => new Program().MainAsync();

    public async Task MainAsync() {
        _client = new DiscordSocketClient();
        
        // Token should be stored in an environment variable called "token".
        var token = Environment.GetEnvironmentVariable("token");
        
        // Log in to Discord
        await _client.LoginAsync(TokenType.Bot, token);
        await _client.StartAsync();
        
        // Block this task until the program is closed
        await Task.Delay(-1);
    }

    private Task Log(LogMessage msg) {
        Console.WriteLine(msg.ToString());
        return Task.CompletedTask;
    }
}