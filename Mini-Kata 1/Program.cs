using Microsoft.CSharp.RuntimeBinder;

namespace WhiteBelt;

class Program
{
    static void Main(string[] args)
    {
        string name;
        int health;
        float attackPower;
        bool magicAbility;
        double currencyAmount;

        name = "Arin";
        health = 100;
        attackPower = 15.5f;
        magicAbility = true;
        currencyAmount = 24.75;
        
        Console.WriteLine($"Character Name: {name}");
        Console.WriteLine($"Health Points: {health}");
        Console.WriteLine($"Attack Power: {attackPower}");
        Console.WriteLine($"Has Magic Ability: {magicAbility}");
        Console.WriteLine($"Gold Coins: {currencyAmount}");
    }
}