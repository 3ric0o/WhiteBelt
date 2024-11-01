namespace WhiteBelt;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int playerLuck = random.Next(0, 11);
        Console.WriteLine("Do you want to Attack an enemy (y/n)?");
        string input = Console.ReadLine();
        
        while (input.ToLower() != "y" && input.ToLower() != "n")
        {
            Console.WriteLine("Incorrect input");
            Console.WriteLine("Do you want to Attack an enemy (y/n)?");
            input = Console.ReadLine();
        }

        if (input.ToLower() == "y")
        {
            Console.WriteLine("Attempting to attack...");
            if (playerLuck > 7)
            {
                Console.WriteLine($" Your luck is: {playerLuck}\nSuccess! Your attack hits the enemy.");
            }
            else if (playerLuck == 6)
            {
                Console.WriteLine($" Your luck is: {playerLuck}\nSuccess! Your attack barely succeeded!"); 
            }
            else
            {
                Console.WriteLine($" Your luck is: {playerLuck}\nYour attack missed!");
            }
        }
        else
        {
            Console.WriteLine("Player retreated...");
        }
        
    }
}