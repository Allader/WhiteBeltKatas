using System.Runtime.InteropServices;

namespace WhiteBeltKatas2;

class Program
{
    static void Main(string[] args)
    {
        string name = "Lira";
        int level = 5;
        float health = 75.5f;
        double experience = 50;
        bool magicAbility = true;
        char rank = (char)('A');

        var newlevel = (level) - (experience);
        // psuedo code
        // if exp = smth 
        // & left exp stores in exp
        //lvl +1

        if (experience <= 100)
        {
            level += 1;
        }
        
        Console.WriteLine("Let's get some exp!");
        Console.WriteLine("+50EXP");
        experience += 60;
        Console.WriteLine($"{name} has {level} levels.");
    }
}