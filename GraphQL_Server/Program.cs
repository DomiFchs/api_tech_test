using GraphQL_Server.Entities.Mutations;
using GraphQL_Server.Entities.Queries;
using GraphQL_Server.Entities.Subscriptions;
using Shared.Services;
using StackExchange.Redis;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<BillService>();

builder.Services.AddGraphQLServer()
    .AddQueryType<BillQuery>()
    .AddMutationType<BillMutation>()
    .AddSubscriptionType<BillSubscription>()
    .AddInMemorySubscriptions()
    .AddRedisSubscriptions(sp => ConnectionMultiplexer.Connect("localhost:5080"));

var app = builder.Build();

app.UseRouting();
app.MapGraphQL();
app.UseWebSockets();


app.Run();