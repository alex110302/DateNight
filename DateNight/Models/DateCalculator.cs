namespace DateNight.Models;

public class DateCalculator
{
    public string CoffeeCost { get; set; }
    public string DinnerCost { get; set; }
    public string MovieCost { get; set; }
    
    public string GetTotalCost()
    {
        decimal decCoffee = CheckCostInput(CoffeeCost, "Coffee");
        decimal decDinner = CheckCostInput(DinnerCost, "Dinner");
        decimal decMovie = CheckCostInput(MovieCost, "Movie");

        return (decCoffee + decDinner + decMovie).ToString("c");
    }

    private decimal CheckCostInput(string itemInput, string itemName)
    {
        decimal itemCost;
        if (!decimal.TryParse(itemInput, out itemCost) && !string.IsNullOrEmpty(itemInput))
            throw new Exception($"Invalid {itemName} Cost");
        return itemCost;
    }
}