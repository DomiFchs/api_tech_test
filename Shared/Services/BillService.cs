using Shared.Entities;

namespace Shared.Services;

public class BillService {

    private static List<Bill> _bills = [];
    public Bill Bill1() {
        return new Bill {
            Id = "1",
            Title = "Bill 1",
            BillDate = DateTime.Now,
            SendStartEmail = true,
            Description = "This is the first bill"
        };
    }
    
    public Bill Bill2() {
        return new Bill {
            Id = "2",
            Title = "Bill 2",
            BillDate = DateTime.Now,
            SendStartEmail = true,
            Description = "This is the second bill"
        };
    }
    
    public Bill Bill3() {
        return new Bill {
            Id = "3",
            Title = "Bill 3",
            BillDate = DateTime.Now,
            SendStartEmail = true,
            Description = "This is the third bill"
        };
    }
    
    public Bill Bill4() {
        return new Bill {
            Id = "4",
            Title = "Bill 4",
            BillDate = DateTime.Now,
            SendStartEmail = true,
            Description = "This is the fourth bill"
        };
    }
    
    public Bill Bill5() {
        return new Bill {
            Id = "5",
            Title = "Bill 5",
            BillDate = DateTime.Now,
            SendStartEmail = true,
            Description = "This is the fifth bill"
        };
    }
    
    public Bill Bill6() {
        return new Bill {
            Id = "6",
            Title = "Bill 6",
            BillDate = DateTime.Now,
            SendStartEmail = true,
            Description = "This is the sixth bill"
        };
    }
    
    public Bill Bill7() {
        return new Bill {
            Id = "7",
            Title = "Bill 7",
            BillDate = DateTime.Now,
            SendStartEmail = true,
            Description = "This is the seventh bill"
        };
    }
    
    public Bill Bill8() {
        return new Bill {
            Id = "8",
            Title = "Bill 8",
            BillDate = DateTime.Now,
            SendStartEmail = true,
            Description = "This is the eighth bill"
        };
    }
    
    public Bill Bill9() {
        return new Bill {
            Id = "9",
            Title = "Bill 9",
            BillDate = DateTime.Now,
            SendStartEmail = true,
            Description = "This is the ninth bill"
        };
    }
    
    public Bill Bill10() {
        return new Bill {
            Id = "10",
            Title = "Bill 10",
            BillDate = DateTime.Now,
            SendStartEmail = true,
            Description = "This is the tenth bill"
        };
    }
    
    public Bill GetRandomBill() {
        var random = new Random();
        var number = random.Next(1, 11);
        return number switch {
            1 => Bill1(),
            2 => Bill2(),
            3 => Bill3(),
            4 => Bill4(),
            5 => Bill5(),
            6 => Bill6(),
            7 => Bill7(),
            8 => Bill8(),
            9 => Bill9(),
            10 => Bill10(),
            _ => Bill1()
        };
    }

    public IEnumerable<Bill> GetBills(int count) {
        
        var bills = new List<Bill>();
        
        for (var i = 0; i < count; i++) {
            var bill = GetRandomBill();
            bills.Add(bill);
        }

        return bills;
    }
    
    public Bill GetBill(string id) {
        return id switch {
            "1" => Bill1(),
            "2" => Bill2(),
            "3" => Bill3(),
            "4" => Bill4(),
            "5" => Bill5(),
            "6" => Bill6(),
            "7" => Bill7(),
            "8" => Bill8(),
            "9" => Bill9(),
            "10" => Bill10(),
            _ => Bill1()
        };
    }
    
    public async Task<Bill> AddBillAsync(Bill bill) {
        _bills.Add(bill);
        await Task.CompletedTask;
        return bill;
    }
}