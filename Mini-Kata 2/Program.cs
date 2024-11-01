namespace WhiteBelt;

class Program
{
    static void Main(string[] args)
    {
        int healthPoints = 100;
        double experiencePoints = 250.75;
        float attackPower = 30.5f;
        string characterName = "Arin";
        string goldCoins = "150";

        double healthPointsDouble = Convert.ToDouble(healthPoints);
        int attackPowerInt = Convert.ToInt32(attackPower);
        int experiencePointsInt = Convert.ToInt32(experiencePoints);
        int goldCoinsInt = Convert.ToInt32(goldCoins);
        
        Console.WriteLine($"Health as double: {healthPointsDouble}");
        Console.WriteLine($"Attack Power as int: {attackPowerInt}");
        Console.WriteLine($"Experience as int: {experiencePointsInt}");
        Console.WriteLine($"Gold Coins as int: {goldCoinsInt}");
        
        if (int.TryParse("Arin", out int currentName))
        {
            Console.WriteLine(currentName);
        }
        else
        {
            Console.WriteLine("Parsing failed: 'invalid' is not a number.");
        }
    }
}