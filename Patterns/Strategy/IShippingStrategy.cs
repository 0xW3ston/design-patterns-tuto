namespace syntaxApp.Patterns.Strategy
{
    public interface IShippingStrategy
    {
        decimal CalculateShippingCost(double weight, double distance);
        bool startShipping();
    }
}
