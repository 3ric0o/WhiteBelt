namespace WhiteBelt;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Spawning enemies using a for loop");

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Enemy #{i+1} spawned!");
        }
        
        Console.WriteLine("\nSpawning enemies using a while loop");
        int enemies = 1;
        while (enemies <= 3)
        {
            Console.WriteLine($"Enemy #{enemies} spawned!");
            enemies++;
        }
    }
}