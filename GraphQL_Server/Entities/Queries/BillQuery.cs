using Shared.Entities;
using Shared.Services;

namespace GraphQL_Server.Entities.Queries;

public class BillQuery(BillService billService){
    public IEnumerable<Bill> GetBills(int count) => billService.GetBills(count);
    public Bill GetBill(string id) => billService.GetBill(id);
}