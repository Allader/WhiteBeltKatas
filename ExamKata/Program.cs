namespace ExamKata;

class Program
{

    static void Main(string[] args)
    {
        //Variables
        int health = 100;
        int enemyHealth = 50;

        Random rand = new Random(); 
       



        while (health > 0 && enemyHealth > 0)
        {
            
            
            
            Console.WriteLine("-=-=-=-=-=-=-=- \n Choose an option: \n 1.Attack \n 2.Heal \n -=-=-=-=-=-=-=-");

            if (Console.ReadLine() == "1")
            {
                int dmg = rand.Next(5, 16);
                int Goblindmg = rand.Next(7, 21); //new random because didn't know how to make it loopable, so I dry...
                
                Console.WriteLine($"You attack the goblin! \n \n You dealt {dmg} to Goblin!");
                enemyHealth -= dmg;
                Console.WriteLine($"Goblin has {enemyHealth} health.");


                Console.WriteLine($"Gobling counter attacks! \n \n Goblin dealt you {Goblindmg}!!");
                health -= Goblindmg;
                Console.WriteLine($"You have now {health} health.");
                Console.ReadKey();

            }
            else if (Console.ReadLine() == "2")
            {
                int heal = rand.Next(3, 6);
                
                Console.WriteLine($"You're healing yourself! \n \n You healed yourself for {heal} !");
                health += heal;
                Console.WriteLine($"You have now {health} health.");
                Console.WriteLine("The best is peeking his nose...");
                Thread.Sleep(2000);
                Console.WriteLine("Disgusting.");
            }
            if (health <= 0)
                Console.WriteLine("-=-=-=-=-=-=-=- \n You have been defeated by the goblin. \n -=-=-=-=-=-=-=-");
            else
                Console.WriteLine("-=-=-=-=-=-=-=- \n Congratulations! The beast is dead! \n -=-=-=-=-=-=-=-");
            
            
        }
    }
}

