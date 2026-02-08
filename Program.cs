var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

// Configure endpoints
app.MapGet("/", () => new
{
    message = "DemoWebApp - Deployment Başarılı! 🚀",
    version = "1.0.0",
    timestamp = DateTime.UtcNow,
    environment = app.Environment.EnvironmentName
});

app.MapGet("/health", () => Results.Ok(new
{
    status = "healthy",
    timestamp = DateTime.UtcNow,
    uptime = Environment.TickCount64
}));

app.MapGet("/info", () => new
{
    machineName = Environment.MachineName,
    osVersion = Environment.OSVersion.ToString(),
    dotnetVersion = Environment.Version.ToString(),
    processorCount = Environment.ProcessorCount
});

app.Run();
