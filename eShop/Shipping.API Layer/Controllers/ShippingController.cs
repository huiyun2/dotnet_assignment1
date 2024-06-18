using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class ShippingController : ControllerBase
{
    private readonly IShippingService _shippingService;

    public ShippingController(IShippingService shippingService)
    {
        _shippingService = shippingService;
    }

    [HttpPost]
    public async Task<IActionResult> CalculateShipping([FromBody] ShippingRequest request)
    {
        var result = await _shippingService.CalculateShippingCostAsync(request);
        return Ok(result);
    }
}
