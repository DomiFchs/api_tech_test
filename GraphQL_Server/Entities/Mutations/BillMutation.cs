using GraphQL_Server.Entities.Subscriptions;
using HotChocolate.Subscriptions;
using Shared.Entities;
using Shared.Services;

namespace GraphQL_Server.Entities.Mutations;

public class BillMutation(BillService billService) {
    
    public async Task<BillAdded> AddBill(Bill bill, [Service] ITopicEventSender sender) {
        var entity = await billService.AddBillAsync(bill);
        
        var billAdded = new BillAdded {
            Id = entity.Id,
            Title = entity.Title
        };

        await sender.SendAsync(nameof(BillSubscription.BillAdded), billAdded);
        
        return billAdded;
    }
}