namespace NonSOLID;

public class Program
{
    public static void Main()
    {
        Product foodProduct = new Product("Bread", "Food", 100);
        Product electronicsProduct = new Product("Laptop", "Electronics", 1000);

        TaxCalculator calculator = new TaxCalculator();

        decimal taxForFoodProduct = calculator.CalculateTax(foodProduct);
        decimal taxForElectronicProduct = calculator.CalculateTax(electronicsProduct);
        
        Console.WriteLine($"Tax for {foodProduct.Name}: {taxForFoodProduct}");
        Console.WriteLine($"Tax for {electronicsProduct.Name}: {taxForElectronicProduct}");
    }
}