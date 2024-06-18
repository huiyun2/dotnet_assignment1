public interface IShippingService
{
    Task<ShippingResult> CalculateShippingCostAsync(ShippingRequest request);
}