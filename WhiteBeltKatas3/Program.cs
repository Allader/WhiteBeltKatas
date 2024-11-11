namespace WhiteBeltKatas3;

class Program
{
    static void Main(string[] args)
    {
        Random rand = new();
        int playerLuck = rand.Next(1, 11);
        //int playerLuck = rand.next(1,4);
        //string[1,2,3] playerLuck = ("Common", "Rare", "Legendary")
        
       Console.WriteLine("\n 1.Open the chest \n 2. Ignore chest \n 3.Leave area");

       if (Console.ReadLine() == "1")
       {
           //DRY ALERT
           if (playerLuck >= 7)
           {
               Console.WriteLine("You found the Legendary loot!!");
           }
           else if (playerLuck == 6)
           {
               Console.WriteLine("You found the Epic loot!");
           }
           else if (playerLuck <= 3)
           {
               Console.WriteLine("You found the Rare loot!");
           }
           else if (playerLuck >= 3)
           {
               Console.WriteLine("Damn, you found garbage.");
           }
       }// A LOT OF DRY BUT, i thought about making a random number appear, and depends on the number it has some "Loot" so if u get 1 u get bad loot etc. (9 && 10)
       else if (Console.ReadLine() == "2")
       {
           Console.WriteLine("You ignored the chest. Good. it might be a mimic!");
       }
       else
       {
           Console.WriteLine("You left the area looking for a better loot");
       }
    }
}