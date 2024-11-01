namespace WhiteBelt;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        string name = "Lira";
        int level = random.Next(1, 6);
        float health = random.Next(50, 101);
        double experience = 525.75;
        bool magic = true;
        char rank = 'A';

        double nextLevelThreshold = 1000;
        double pointsToNextLevel = nextLevelThreshold - experience;
        
        Console.WriteLine($"Character Name: {name}\n" +
                          $"Level: {level}\n" +
                          $"Health: {health}\n" +
                          $"Experience: {experience}\n" +
                          $"Has magic: {magic}\n" +
                          $"Rank: {rank}\n" +
                          $"Points needed to next level: {pointsToNextLevel}");
    }
}