using Yarp.ReverseProxy;

var builder = WebApplication.CreateBuilder(args);

// Add YARP 
builder.Services.AddReverseProxy()
    .LoadFromConfig(builder.Configuration.GetSection("ReverseProxy"));

var app = builder.Build();

// Enable the proxy middleware
app.MapReverseProxy();

app.Run();
