// See https://aka.ms/new-console-template for more information

using Crawlab.RPC;

var client = new RpcClient();
await client.Start();
try
{
    await client.Register("test");
}
catch
{
}


await Task.Delay(600 * 1000);