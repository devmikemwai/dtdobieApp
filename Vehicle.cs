public class Vehicle
{
    public string Make { get; set; }
    public string Model { get; set; }
    public string EngineNumber { get; set; }
    public decimal SalePrice { get; set; }

    public decimal GetProfit()
    {
        return SalePrice * 0.15m;
    }
}
