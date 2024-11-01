Console.WriteLine("Hi, Whats your name?");
string name = Console.ReadLine();

Console.WriteLine($"Greetings, {name}! Your journey begins now...");
Console.WriteLine("On a scale of 1 to 10, how excited are you to start this quest?");
string input = Console.ReadLine();

if (int.TryParse(input, out int excitementlvl))
{
    Console.WriteLine(excitementlvl >= 7
        ? "Fantastic! You seem ready to take on any challenge!"
        : "Dont Worry! It will be fun!");
}
else
{
    Console.WriteLine("That's not a valid integer. Please restart the program and try again.");
}
