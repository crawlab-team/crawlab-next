using Microsoft.AspNetCore.Mvc;
using Crawlab.DB;
using Crawlab.Model.Models;
using Crawlab.RPC;
using Microsoft.AspNetCore.SignalR;

namespace Crawlab.API.Controllers;

[ApiController]
[Route("rpc-test")]
public class RpcTestController
{
    private readonly IHubContext<RpcServer, IRpcClient> _rpcServer;

    public RpcTestController(IHubContext<RpcServer, IRpcClient> rpcServer)
    {
        _rpcServer = rpcServer;
    }

    [HttpGet]
    public async Task<string> Get(string key)
    {
        await _rpcServer.Clients.Group(key).Pong("Pong");
        return "success";
    }
}