using System.Security.Cryptography;

namespace MiniKata4;

class Program
{
    static void Main(string[] args)
    {
        int maxEnemies = 5;
        int minEnemies = 2;
        
        Console.WriteLine("Let's start your training!");
        
        for (int i = 0; i < 5; i++) 
        { 
            Console.WriteLine($"Target Dummy #{i+1} spawned!"); 
        }

        while (0 > maxEnemies)
        {
           Console.WriteLine("Target Dummy has spawned!");
        } 
        
        
        
        
        
    }
}