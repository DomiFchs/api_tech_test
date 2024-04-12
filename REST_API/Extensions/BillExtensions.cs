using REST_API.Dtos;

namespace REST_API.Extensions;

public static class BillExtensions {
    
    public static BillDto ToBillDto(this Shared.Entities.Bill bill) {
        return new BillDto {
            Id = bill.Id,
            Title = bill.Title,
            BillDate = bill.BillDate,
            SendStartEmail = bill.SendStartEmail,
            Description = bill.Description
        };
    }
}