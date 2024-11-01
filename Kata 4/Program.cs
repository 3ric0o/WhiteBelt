namespace WhiteBelt;

class Program
{
    static void Main(string[] args)
    {
        int waves = 3;
        int enemies = 4;
        
        for (int i = 0; i < waves; i++)
        {
            Console.WriteLine($"Waves {i+1} is starting!");
            Thread.Sleep(1000);
            for (int j = 0; j < enemies; j++)
            {
                Console.WriteLine($"Enemy #{j +1} has spawned!");
            }
            Thread.Sleep(1000);
            Console.WriteLine($"Waves {i+1} is Completed. Preparing for the next wave...\n");
            Thread.Sleep(1000);
        }
    }
}