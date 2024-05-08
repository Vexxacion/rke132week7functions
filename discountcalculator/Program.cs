// total < 10 - 1%
// total >= 10 && total < 20 - 5%
// otal >=20 - 10%

Console.WriteLine("Provide total: ");
int userInput = Int32.Parse(Console.ReadLine());

double discount = CalculateDiscount(userInput);

Console.WriteLine($"Your discount is: {discount}%");

double newTotal = CalculatedNewTotal(userInput, discount);

Console.WriteLine($"Your updated total {discount}%: {newTotal}");

static double CalculateDiscount(int total)
{
    if (total > 10)
    {
        return 1;
    }
    else if (total >= 10 && total < 20)
    {
        return 5;
    }
    else
    {
        return 10;
    }
}

static double CalculatedNewTotal(double total, double discount)
{
    double result = (total * discount) / 100;
    return result;
}