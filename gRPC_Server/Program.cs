using gRPC_Server.Services;
using Shared.Configurations;
using Shared.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddGrpc();
builder.Services.AddScoped<BillServer>();
builder.Services.AddScoped<BillService>();



var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapGrpcService<BillServer>();
app.MapGet("/",
    () =>
        "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();