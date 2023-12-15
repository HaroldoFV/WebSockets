using System.Net;
using System.Net.WebSockets;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseWebSockets();

app.Map("/", async context =>
{
    if (!context.WebSockets.IsWebSocketRequest)
        context.Response.StatusCode = (int) HttpStatusCode.BadRequest;
    else
    {
        using var webSocket = await context.WebSockets.AcceptWebSocketAsync();

        var data = Encoding.ASCII.GetBytes($".NET Rocks -> {DateTime.Now}");
        while (true)
        {
            await webSocket.SendAsync(
                data,
                WebSocketMessageType.Text,
                true,
                CancellationToken.None);
            await Task.Delay(1000);
        }
    }
});

await app.RunAsync();