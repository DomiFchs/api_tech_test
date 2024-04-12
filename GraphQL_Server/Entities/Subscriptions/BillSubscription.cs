using Shared.Entities;

namespace GraphQL_Server.Entities.Subscriptions;

public class BillSubscription {
    [Subscribe]
    public BillAdded BillAdded([EventMessage] BillAdded bill) => bill;
}