// semua object atau method di c# memakai PascalCase

public class Program
{
    public static void Main()
    {

        /* 
        Multi Line
         */

        Console.WriteLine("Hello World"); // with new line
        Console.Write("Hello Dunia");

        Console.WriteLine();

        // penulisan variabel
        int number = 10; // explisit
        var number1 = 10; // implisit

        Console.WriteLine(number);
        Console.WriteLine(number1);
        

        // camelCase -> variable
        // PascalCase -> class atau method
        // _underScore -> private field
    }
}