using Google.Protobuf.WellKnownTypes;
using Shared;
using Shared.Entities;

namespace gRPC_Server.Extensions;

public static class BillExtensions {
    
    public static Bill ToBill(this BillResponse request) {
        return new Bill {
            Id = Guid.NewGuid().ToString(),
            Title = request.Title,
            Description = request.Description,
            SendStartEmail = request.SendStartEmail,
            BillDate = request.BillDate.ToDateTime()
        };
    }
    
    public static BillResponse ToBillResponse(this Bill bill) {
        return new BillResponse {
            Id = bill.Id,
            Title = bill.Title,
            BillDate = Timestamp.FromDateTime(bill.BillDate.ToUniversalTime()),
            SendStartEmail = bill.SendStartEmail,
            Description = bill.Description
        };
    }
}