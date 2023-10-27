using TaurusMessengerServer;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapHub<ChatHub>("ChatHub");

app.Run();
