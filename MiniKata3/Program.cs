using System.Data;

namespace MiniKata3;

class Program
{
    static void Main(string[] args)
    {
        
        Random rand = new();
        int playerLuck = rand.Next(1, 11);
        
        

        Console.WriteLine("Do you want to attack? Y/N");
        string question = Console.ReadLine();

        if (question.ToUpper() == "Y")
        {
            if (playerLuck > 7)
            {
                Console.WriteLine("You hit him!");
            }
            else if (playerLuck == 6)
            {
                Console.WriteLine("You successed!");
            }
            else
            {
                Console.WriteLine("You missed...");
            }
            
        }
        else if (question.ToUpper() == "N")
        {
            Console.WriteLine("Sadpepe...");
            
        }

    }
}