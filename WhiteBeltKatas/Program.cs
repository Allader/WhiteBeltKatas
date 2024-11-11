class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome adventurer! What is your name...");
        string name = Console.ReadLine();
            Console.WriteLine($"Greetings, {name} Your journey begins now...");
            Console.WriteLine("On a scale of 1 to 10, how excited are you to start this quest?");
            int choice = int.Parse(Console.ReadLine());

            if (choice <=5)
            {
                Console.WriteLine("You seem not sure");
            }
            else if (choice >= 5)
            {
                Console.WriteLine("You seem ready!");
            }
    }
}
