using gRPC_Client.Services;
using Shared.Configurations;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHostedService<BillClient>();

builder.Services.Configure<GrpcCfg>(cfg =>
{
    cfg.Host = builder.Configuration["gRPC:Host"] ?? throw new ArgumentNullException("gRPC:Host");
    cfg.Port = int.Parse(builder.Configuration["gRPC:Port"] ?? throw new ArgumentNullException("gRPC:Port"));
});

var app = builder.Build();
app.Run();