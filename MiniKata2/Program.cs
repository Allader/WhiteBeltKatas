namespace MiniKata2;

class Program
{
    static void Main(string[] args)
    {
        string name = "Arin";
        int health = 100;
        float attack = 15.5f;
        float ExperiencePoints = 250f;
        bool IsParalized = false;
        string currencyString = "150,333333";
        

        double healthDouble = health; //implicit

      //  double healthDouble2 = (double)health; //explicit
        
      //  Convert.ToDouble(health); //explicit 
      
        // converters
        Convert.ToInt32(attack);
        
        Convert.ToInt32(ExperiencePoints);
        
        Convert.ToDouble(currencyString);
        //Output
        Console.WriteLine(healthDouble);
        
        Console.WriteLine(attack);
        
        Console.WriteLine(ExperiencePoints);
        
        Console.WriteLine(currencyString);
        
        Console.WriteLine("Let's try converting Arin to int");
        if (int.TryParse(name, out int result))
        {
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Invalid can't convert to int");
        }
    }
}