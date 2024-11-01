namespace WhiteBelt;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int playerLuck = rnd.Next(0, 11);
        bool validInput = false;

        while (!validInput)
        {
            Console.WriteLine("Choose an option:\n" +
                              "1. Open the chest\n" +
                              "2. Leave the chest\n" +
                              "3. Leave the area");
            
            if (int.TryParse(Console.ReadLine(), out int option))
            {
                validInput = true;

                if (option == 1)
                {
                    Console.WriteLine("You try to open the chest...");
                    Console.WriteLine($"Player luck: {playerLuck}");
                    if (playerLuck > 7)
                    {
                        Console.WriteLine("Success! The chest contains a rare gem.");
                    }
                    else if (playerLuck >= 5)
                    {
                        Console.WriteLine("You found some Gold.");
                    }
                    else
                    {
                        Console.WriteLine("The chest was trapped!");
                    }
                }
                else if (option == 2)
                {
                    Console.WriteLine("The Player continued on his journey leaving the chest behind.");
                }
                else if (option == 3)
                {
                    Console.WriteLine("You leave the area! The mystery was left unsolved.");
                }
                else
                {
                    Console.WriteLine("Invalid option. Please choose again.");
                    validInput = false;
                }
            }
            else
            {
                Console.WriteLine("That's not a valid integer. Please try again.");
            }
        }
    }
}