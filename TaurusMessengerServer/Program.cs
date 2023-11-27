using TaurusMessengerServer;
using TaurusMessengerServer.Service;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSignalR();
builder.Services.AddSingleton<DatabaseService>();
DatabaseService ds = new DatabaseService();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapHub<ChatHub>("ChatHub");

app.Run();
