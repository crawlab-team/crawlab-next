using Crawlab.Model.Models;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Task = System.Threading.Tasks.Task;

namespace Crawlab.RPC;

public class RpcClient : IRpcClient
{
    private readonly ILogger<RpcClient> _logger = new NullLogger<RpcClient>();
    private readonly HubConnection _connection;

    public RpcClient()
    {
        _connection = new HubConnectionBuilder()
            .WithUrl("http://localhost:5129/rpc")
            .Build();

        _connection.Closed += async (error) =>
        {
            await Task.Delay(new Random().Next(0, 5) * 1000);
            await _connection.StartAsync();
        };

        _connection.On<string>("Pong", Pong);
    }

    public async Task Start()
    {
        await _connection.StartAsync();
        _logger.LogInformation("RPC client started");
    }

    public async Task<string> Ping(string message)
    {
        return await _connection.InvokeAsync<string>("Ping", message);
    }

    public async Task Pong(string message)
    {
        _logger.LogInformation("Pong: {Message}", message);
    }

    public async Task<Node> Register(string key)
    {
        return await _connection.InvokeAsync<Node>("Register", key);
    }

    public async Task<Node?> Report(int nodeId)
    {
        return await _connection.InvokeAsync<Node>("Report", nodeId);
    }
}