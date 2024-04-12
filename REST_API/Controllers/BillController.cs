using Microsoft.AspNetCore.Mvc;
using REST_API.Dtos;
using REST_API.Extensions;
using Shared.Services;

namespace REST_API.Controllers;

[ApiController]
[Route("bills")]
public class BillController(BillService service) : ControllerBase {
    
    [HttpGet("random")]
    public async Task<ActionResult<BillDto>> GetRandomBill() {
        var bill = service.GetRandomBill();
        var dto = bill.ToBillDto();
        return Ok(dto);
    }
}