namespace FundamentalUpskilling;

public class Conditional
{
    public void Main(string[] args)
    {
        /* 
        if (conditional operator)
        {
            statement
            
        }
         */

        int i = 10;
        int j = 20;
        if (i == j)
        {
            System.Console.WriteLine("i sama dengan j");
        }
        else if (i > j)
        {
            System.Console.WriteLine("i lebih dari j");
        }
        else if (i < j)
        {
            System.Console.WriteLine("i kurang dari j");
        }
        else
        {
            System.Console.WriteLine("i tidak sama dengan j");
        }

        // penyedehanan if else statement

        var grade = 'A';

        switch (grade)
        {
            case 'A': System.Console.WriteLine("Excellent"); break;
            case 'B': System.Console.WriteLine("Good"); break;
            case 'C': System.Console.WriteLine("Not Bad"); break;
            case 'D': System.Console.WriteLine("Failed"); break;
            default: System.Console.WriteLine("invalid grade"); break;
        }
    }
}
