namespace WhiteBelt
{
    class Exam_Kata
    {
        static void Main(string[] args)
        {
            string player = "Hero";
            int maxHealth = 50;
            int playerHealth = maxHealth;
            int playerDamage = 15;
            int healAmount = 25;

            string enemy = "Goblin";
            int enemyHealth = 35;
            int enemyDamage = 10;

            while (true) // (playerHealth > 0 && enemyHealth > 0)
            {
                Console.WriteLine($"{player}'s Health: {playerHealth}\n" +
                                  $"{enemy}'s Health: {enemyHealth}\n");

                Console.WriteLine("Choose an action:\n" +
                                  "1. Attack\n" +
                                  "2. Heal");
                
                bool validInput = int.TryParse(Console.ReadLine(), out int optionInput);

                if (validInput && optionInput is 1 or 2)
                {
                    if (optionInput == 1) // Attack
                    {
                        Console.WriteLine($"\n{player} attacks the {enemy}!\n" +
                                          $"{enemy} takes {playerDamage} damage.\n");
                        enemyHealth -= playerDamage;

                        if (enemyHealth <= 0)
                        {
                            Console.WriteLine($"Congratulations! You have defeated the {enemy}!");
                            return;
                        }

                        Console.WriteLine($"{enemy} attacks {player}!\n" +
                                          $"{player} takes {enemyDamage} damage.\n");
                        playerHealth -= enemyDamage;

                        if (playerHealth > 0) continue;
                        Console.WriteLine($"You lose! The {enemy} has slain you!");
                        return;
                    }
                    // Heal
                    Console.WriteLine($"{player} heals for {healAmount}.\n");
                    playerHealth += healAmount;

                    if (playerHealth > maxHealth)
                    {
                        playerHealth = maxHealth;
                    }
                    
                    Console.WriteLine($"{enemy} attacks {player}!\n" +
                                      $"{player} takes {enemyDamage} damage.\n");
                    playerHealth -= enemyDamage;

                    if (playerHealth > 0) continue;
                    Console.WriteLine($"You lose! The {enemy} has slain you!");
                    return;
                }
                Console.WriteLine("\nInvalid option. Please choose 1 or 2.\n");
            }
        }
    }
}
