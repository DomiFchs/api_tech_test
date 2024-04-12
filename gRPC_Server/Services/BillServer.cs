

using gRPC_Server.Extensions;
using Grpc.Core;
using Shared;
using Shared.Services;
using BillService = Shared.Services.BillService;

namespace gRPC_Server.Services;

public class BillServer(ILogger<BillServer> logger, BillService billService) : Shared.BillService.BillServiceBase
{
    public override async Task BillService(GetBillsRequest request, IServerStreamWriter<BillResponse> responseStream, ServerCallContext context) {
        logger.LogInformation("Starting to Stream");
        for (var i = 0; i <= request.Count; i++) {
            var bill = billService.GetRandomBill();
            
            var response = bill.ToBillResponse();
            
            await responseStream.WriteAsync(response);
        }
        logger.LogInformation("Finished Streaming");
    }
}