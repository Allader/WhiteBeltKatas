namespace Kata4;

class Program
{
    static void Main(string[] args)
    {
        int totalWaves = 2;
        int enemiesPerWave = 5;
        for (int wave = 1; wave <= totalWaves; wave++)
        {
            
            Console.WriteLine($"Wave #{wave} is starting!");
            Console.WriteLine("-=-=-=-=-=-=-=-=-");
            for (int enemy = 1; enemy <= enemiesPerWave; enemy++)
            {
                
                Console.WriteLine($"Enemy #{enemy} has spawned.");
                Thread.Sleep(1000);
            }
            Console.WriteLine("-=-=-=-=-=-=-=-=-");
            Thread.Sleep(2000);
            Console.WriteLine($"The wave {wave} is finished!");
            
        }
        
        
    }
}